using Microsoft.EntityFrameworkCore;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.Models.Books;
using POS.Shared.ViewModels;
using POS.Shared.ViewModels.Books;
using POS.WebApi.Contracts;
using POS.WebApi.Contracts.Books;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories.Books
{
    public class SQLBookRepository : IBookRepository
    {
        private readonly DataContext dbContext;
        public SQLBookRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Item_UnitModel> getBookItemUnit(int bookId)
        {
            ItemModel item=await dbContext.Item.FirstOrDefaultAsync(r=>r.Book_ID==bookId);
            if (item == null)
            {
                return null;
            }
            else
            {
                return await dbContext.Item_Unit.FirstOrDefaultAsync(r => r.Item_ID == item.Item_ID);
            }
        }
        public async Task<BookModel> createAsync(BookModel model, decimal itemUnitPrice, decimal itemUnitCost, int qnt, string barcode, IItemRepository itemRepository)
        {
            try
            {
                using (var tranaction = dbContext.Database.BeginTransaction())
                {
                    int bookID;
                    if (dbContext.Book.Count() == 0)
                        bookID = 0;
                    else
                        bookID = dbContext.Book.Max(r => r.Book_ID);
                    model.Book_ID = bookID + 1;
                    await dbContext.Book.AddAsync(model);
                    await dbContext.SaveChangesAsync();
                    AddItemRequestModel itemRequest = new AddItemRequestModel();
                    itemRequest.Barcode = barcode;
                    itemRequest.Has_Expiry_Date = false;
                    itemRequest.Is_Main_Unit = true;
                    itemRequest.Default_Unit = true;
                    itemRequest.ItemGroupID = 0;
                    itemRequest.ItemNotes = string.Empty;
                    itemRequest.Item_Brand_ID = 0;
                    itemRequest.Item_Desc = model.Book_Title;
                    itemRequest.Item_Unit_Cost = itemUnitCost;
                    itemRequest.Item_Unit_Price = itemUnitPrice;
                    itemRequest.Qnt_In_Basic_Unit = 1;
                    itemRequest.Source_ID = 0;
                    itemRequest.UnitID = 4;
                    itemRequest.Book_ID = model.Book_ID;
                    itemRequest.User_Name = model.User_Name;
                    ItemModel item = await itemRepository.createAsync(itemRequest, true);
                    if (item != null)
                    {
                        if (qnt > 0)
                        {
                            var itemBeginQntModel = await itemRepository.addBeginQntAsync(new Item_Unit_Begin_Qnt_Model()
                            {
                                Item_Unit_ID = item.Item_ID,
                                Time_Stamp = General.GetCurrentTime(),
                                User_Name = model.User_Name,
                            }, qnt, true);
                            if (itemBeginQntModel == null)
                            {
                                tranaction.Rollback();
                                throw new Exception("can not create Item Begining QNT");
                            }
                        }
                    }
                    else
                    {
                        tranaction.Rollback();
                        throw new Exception("can not create Item");
                    }
                    tranaction.Commit();
                    return model;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<BookModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Book.AsQueryable();
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
        public async Task<BookModel> getByIdAsync(int bookID)
        {
            return await dbContext.Book.FirstOrDefaultAsync(r => r.Book_ID == bookID);
        }
        public async Task<BookModel?> updateAsync(int bookID, BookModel model, decimal itemUnitPrice, decimal itemUnitCost, IItemRepository itemRepository)
        {
            using(var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    dbContext.Book.Update(model);
                    await dbContext.SaveChangesAsync();
                    ItemModel item = await dbContext.Item.FirstOrDefaultAsync(r=>r.Book_ID==bookID);
                    if (item != null)
                    {
                        item.Item_Desc=model.Book_Title;
                        dbContext.Item.Update(item);
                        await dbContext.SaveChangesAsync();
                        Item_UnitModel itemUnit =await dbContext.Item_Unit.FirstOrDefaultAsync(r => r.Item_ID == item.Item_ID);
                        if (itemUnit != null)
                        {
                            itemUnit.Item_Unit_Price = itemUnitPrice;
                            itemUnit.Item_Unit_Cost = itemUnitCost;
                            dbContext.Update(itemUnit);
                            await dbContext.SaveChangesAsync();
                        }
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
        public async Task<BookModel?> deleteAsync(int bookID)
        {
            var model = await dbContext.Book.FirstOrDefaultAsync(r => r.Book_ID == bookID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Book.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<vBooksModel>> getAllAsync(vBookQueryCriteriaViewModel criteria)
        {

            var query = dbContext.vBooks.AsQueryable();
            if (criteria.BookId != null)
            {
                query = query.Where(r => r.Book_ID == criteria.BookId);
            }

            if (criteria.PublisherId != null)
            {
                query = query.Where(r => r.Book_Publisher_ID >= criteria.PublisherId);
            }
            if (criteria.SubjectId != null)
            {
                query = query.Where(r => r.Book_Subject_ID >= criteria.SubjectId);
            }
            if (criteria.BookAuthorId != null)
            {
                query = query.Where(r => r.Book_Author_ID == criteria.BookAuthorId);
            }
            if (!string.IsNullOrEmpty(criteria.BookAuthorName))
            {
                query = query.Where(r => EF.Functions.Like(r.Book_Author_Desc, "%" + criteria.BookAuthorName.Trim().Replace(" ", "%") + "%"));
            }
            if (!string.IsNullOrEmpty(criteria.Barcode))
            {
                query = query.Where(r => r.Barcode.Equals(criteria.Barcode.Trim()));
            }
            if (!string.IsNullOrEmpty(criteria.BookTitle))
            {
                query = query.Where(r => EF.Functions.Like(r.Book_Title, "%" + criteria.BookTitle.Trim().Replace(" ", "%") + "%"));
                //query.Where(r => EF.Functions.Like(r.Book_Title, "%" + General.Recontruct(criteria.BookTitle).Trim().Replace(" ", "%") + "%"));
            }
            if (criteria.FromBookPrice != null)
            {
                query = query.Where(r => r.Item_Unit_Price >= criteria.FromBookPrice);
            }
            if (criteria.ToBookPrice != null)
            {
                query = query.Where(r => r.Item_Unit_Price <= criteria.ToBookPrice);
            }
            if (criteria.FromRemainBookCount != null)
            {
                query = query.Where(r => r.RemainQNT >= criteria.FromRemainBookCount);
            }
            if (criteria.ToRemainBookCount != null)
            {
                query = query.Where(r => r.RemainQNT <= criteria.ToRemainBookCount);
            }

            return await query.ToListAsync();

        }
        public async Task<vBooksModel> getBookAsync(int bookId)
        {
            return await dbContext.vBooks.FirstOrDefaultAsync(r => r.Book_ID == bookId);

        }
    }

}
