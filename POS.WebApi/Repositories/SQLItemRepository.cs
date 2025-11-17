using Azure.Core;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using POS.Shared;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.WebApi.Repositories
{
    public class SQLItemRepository : IItemRepository
    {
        private readonly Data.DataContext dbContext;
        public SQLItemRepository(Data.DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private async Task<ItemModel> addItem(AddItemRequestModel request)
        {
            try
            {
                int itemID = 0;
                if (dbContext.Item.Count() > 1)
                    itemID = dbContext.Item.Max(r => r.Item_ID);
                itemID += 1;
                ItemModel model = new ItemModel()
                {
                    Item_ID = itemID,
                    Book_ID=request.Book_ID,
                    Item_Brand_ID = request.Item_Brand_ID,
                    Item_Desc = request.Item_Desc,
                    Item_Group_ID = request.ItemGroupID,
                    Source_ID = request.Source_ID,
                    Notes = request.ItemNotes,
                    Item_Status_ID = 1,
                    User_Name = request.User_Name,
                    Time_Stamp = General.GetCurrentTime(),
                    Item_Has_Expiry_Date = request.Has_Expiry_Date
                };
                dbContext.Item.Add(model);
                dbContext.SaveChanges();
                short itemUnitID = 0;
                if (dbContext.Item_Unit.Count() > 1)
                    itemUnitID = dbContext.Item_Unit.Max(r => r.Item_Unit_ID);
                itemUnitID += 1;

                //SQLItem_UnitRepository itemUnitRepository = new(dbContext);
                Item_UnitModel itemUnitModel = new Item_UnitModel
                {
                    Item_Unit_ID = itemUnitID,
                    Default_Unit = true,
                    Barcode = request.Barcode,
                    Is_Main_Unit = true,
                    Item_ID = itemID,
                    Item_Unit_Cost = request.Item_Unit_Cost,
                    Item_Unit_Price = request.Item_Unit_Price,
                    Qnt_In_Basic_Unit = 1,
                    Unit_ID = request.UnitID,
                    User_Name = request.User_Name,
                    Time_Stamp = General.GetCurrentTime()
                };
                //await itemUnitRepository.createAsync(itemUnitModel);
                var result = dbContext.Item_Unit.Add(itemUnitModel);
                dbContext.SaveChanges();
                return model;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<ItemModel> createAsync(AddItemRequestModel request, bool hasExternalTransaction = false)
        {
            if (hasExternalTransaction)
            {
                try
                {
                    ItemModel model = await addItem(request);
                    return model;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        ItemModel model = await addItem(request);
                        transaction.Commit();
                        return model;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }

                }
            }
        }
        public async Task<List<ItemModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Item.AsQueryable();
            if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    //qView = qView.Where(r => r. Book_Author_Desc.Contains(filterQuery));
                }
            }
            if (pageSize == 0)
            {
                return await qView.ToListAsync();
            }
            else
            {
                var skipResults = (pageNumber - 1) * pageSize;
                return await qView.Skip(skipResults).Take(pageSize).ToListAsync();
            }
        }
        public async Task<ItemModel> getByIdAsync(int itemID)
        {
            return await dbContext.Item.FirstOrDefaultAsync(r => r.Item_ID == itemID);
        }
        public async Task<ItemModel?> updateAsync(UpdateItemRequestModel request)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    
                    ItemModel itemModel = await getByIdAsync(request.Item_ID);
                    if (itemModel == null)
                        throw new Exception("Item Not Found");
                    itemModel.Item_Desc = request.Item_Desc;
                    itemModel.Notes = request.ItemNotes;
                    itemModel.Item_Brand_ID = request.Item_Brand_ID;
                    itemModel.Item_Group_ID = request.ItemGroupID;
                    itemModel.Source_ID = request.Source_ID;
                    itemModel.QuickAccess=request.QuickAccess;

                    dbContext.Item.Update(itemModel);
                    await dbContext.SaveChangesAsync();

                    //SQLItem_UnitRepository itemUnitRepository = new SQLItem_UnitRepository(dbContext);
                    Item_UnitModel itemUnitModel =await dbContext.Item_Unit.FirstOrDefaultAsync(r=>r.Item_Unit_ID == request.Item_Unit_Id);
                    if (itemUnitModel == null)
                        throw new Exception("Item Unit Not Found");
                    itemUnitModel.Item_Unit_Cost = request.Item_Unit_Cost;
                    itemUnitModel.Item_Unit_Price = request.Item_Unit_Price;
                    itemUnitModel.Unit_ID = request.UnitID;
                    itemUnitModel.Barcode = request.Barcode;
                    
                    dbContext.Item_Unit.Update(itemUnitModel);
                    dbContext.SaveChanges();
                    //itemUnitRepository.updateAsync(itemUnitModel);
                    transaction.Commit();
                    return itemModel;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
        public async Task<ItemModel?> deleteAsync(int itemId)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    var itemUnit = await dbContext.Item_Unit.FirstOrDefaultAsync(r => r.Item_ID == itemId);
                    if (itemUnit == null)
                    {
                        //return null;
                    }
                    else
                    {
                        dbContext.Item_Unit.Remove(itemUnit);
                        await dbContext.SaveChangesAsync();
                    }

                    var model = await dbContext.Item.FirstOrDefaultAsync(r => r.Item_ID == itemId);
                    if (model == null)
                    {
                        //return null;
                    }
                    else
                    {
                        if(model.Book_ID!= null)
                        {
                            var book= dbContext.Book.FirstOrDefaultAsync(r => r.Book_ID == model.Book_ID);
                            if (book == null)
                            {
                                //return null;
                            }
                            else
                            {
                                dbContext.Book.Remove(await book);
                                await dbContext.SaveChangesAsync();
                            }
                        }
                        dbContext.Item.Remove(model);
                        await dbContext.SaveChangesAsync();
                    }
                    transaction.Commit();
                    return model;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public async Task<ItemModel?> updateItemFileUriAsync(int itemId, string fileUri)
        {
            ItemModel item=await dbContext.Item.Where(r=>r.Item_ID==itemId).FirstOrDefaultAsync();
            if(item!= null)
            {
                item.FileUrl = fileUri;
                dbContext.Update(item);
                dbContext.SaveChanges();
                return item;
            }
            return null;
        }

        private async Task<Item_Unit_Begin_Qnt_Model> doAddBeginQntAsync(Item_Unit_Begin_Qnt_Model model, int Qnt)
        {
            try
            {
                int beginQntId = 0;
                Item_Unit_Begin_Qnt_Model existModel = await dbContext.ItemUnitBeginQNT.Where(r => r.Item_Unit_ID == model.Item_Unit_ID).FirstOrDefaultAsync();
                if (existModel != null)
                {
                    Stock_Model itemStock = await dbContext.Stock.Where(r => r.Item_Unit_ID == model.Item_Unit_ID && r.Transaction_Type_ID == Convert.ToByte(TransactionEnum.BeginQnt)).FirstOrDefaultAsync();
                    itemStock.In_QNT = Qnt;
                    dbContext.Stock.Update(itemStock);
                    dbContext.SaveChanges();
                }
                else
                {
                    if (dbContext.ItemUnitBeginQNT.Count() > 1)
                        beginQntId = dbContext.ItemUnitBeginQNT.Max(r => r.Item_Unit_Begin_Qnt_ID);
                    beginQntId += 1;
                    model.Item_Unit_Begin_Qnt_ID = beginQntId;
                    await dbContext.ItemUnitBeginQNT.AddAsync(model);
                    dbContext.SaveChanges();
                    Stock_Model itemStock = await dbContext.Stock.Where(r => r.Item_Unit_ID == model.Item_Unit_ID && r.Transaction_Type_ID == Convert.ToByte(TransactionEnum.BeginQnt)).FirstOrDefaultAsync();
                    if (itemStock == null)
                    {
                        Stock_Model stock_ = new Stock_Model()
                        {
                            In_QNT = Qnt,
                            Item_Unit_ID = model.Item_Unit_ID,
                            Out_QNT = 0,
                            User_Name = model.User_Name,
                            Time_Stamp = General.GetCurrentTime(),
                            Stock_Notes = string.Empty,
                            Transaction_Type_ID = Convert.ToByte(TransactionEnum.BeginQnt),
                            Transaction_ID = beginQntId,
                        };
                        int stockId = 0;
                        if (dbContext.ItemUnitBeginQNT.Count() > 1)
                            stockId = dbContext.Stock.Max(r => r.Stock_ID);

                        stockId += 1;
                        stock_.Stock_ID = stockId;
                        await dbContext.Stock.AddAsync(stock_);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        itemStock.In_QNT = Qnt;
                        dbContext.Stock.Update(itemStock);
                        dbContext.SaveChanges();
                    }
                }
                return model;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<Item_Unit_Begin_Qnt_Model> addBeginQntAsync(Item_Unit_Begin_Qnt_Model request, int Qnt, bool hasExternalTransaction = false)
        {
            if (hasExternalTransaction)
            {
                try
                {
                    Item_Unit_Begin_Qnt_Model model = await doAddBeginQntAsync(request,Qnt);
                    return model;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        Item_Unit_Begin_Qnt_Model model = await doAddBeginQntAsync(request, Qnt);
                        transaction.Commit();
                        return model;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }

                }
            }
        }
    }

}
