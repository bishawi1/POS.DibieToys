using Microsoft.EntityFrameworkCore;
using POS.DAL.Contracts;
using POS.DAL.Data;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Repositories
{
    public class SQLItemRepository : IItemRepository
    {
        private readonly DataContext dbContext;
        public SQLItemRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ItemModel> createAsync(AddItemRequestModel request)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
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
                        Item_Brand_ID = request.Item_Brand_ID,
                        Item_Desc = request.Item_Desc,
                        Item_Group_ID = request.ItemGroupID,
                        Notes = request.ItemNotes,
                        Item_Status_ID = 1,
                        User_Name = request.User_Name,
                        Time_Stamp = DateTime.Now,
                        Item_Has_Expiry_Date = request.Has_Expiry_Date
                    };
                    dbContext.Item.Add(model);
                    dbContext.SaveChanges();
                    short itemUnitID = 0;
                    if(dbContext.Item_Unit.Count()>1)
                        itemUnitID= dbContext.Item_Unit.Max(r => r.Item_Unit_ID);
                    itemUnitID += 1;
                    
                    SQLItem_UnitRepository itemUnitRepository = new(dbContext);
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
                        Time_Stamp = DateTime.Now
                    };
                    await itemUnitRepository.createAsync(itemUnitModel);
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
                    dbContext.Item.Update(itemModel);
                    await dbContext.SaveChangesAsync();

                    SQLItem_UnitRepository itemUnitRepository = new SQLItem_UnitRepository(dbContext);
                    Item_UnitModel itemUnitModel =await itemUnitRepository.getByIdAsync(request.Item_Unit_Id);
                    if (itemUnitModel == null)
                        throw new Exception("Item Unit Not Found");
                    itemUnitModel.Item_Unit_Cost = request.Item_Unit_Cost;
                    itemUnitModel.Item_Unit_Price = request.Item_Unit_Price;
                    itemUnitModel.Unit_ID = request.UnitID;
                    itemUnitModel.Barcode = request.Barcode;

                    itemUnitRepository.updateAsync(itemUnitModel);
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
        public async Task<ItemModel?> deleteAsync(int itemStatusID)
        {
            var model = await dbContext.Item.FirstOrDefaultAsync(r => r.Item_Status_ID == itemStatusID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Item.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
