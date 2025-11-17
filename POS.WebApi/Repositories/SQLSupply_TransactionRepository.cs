using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLSupply_TransactionRepository : ISupply_TransactionRepository
    {
        private readonly DataContext dbContext;
        public SQLSupply_TransactionRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Supply_TransactionModel> createAsync(Supply_TransactionModel model)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    int supplyTransactionID;
                    int stockId;
                    if (dbContext.Supply_Transaction.Count() == 0)
                        supplyTransactionID = 0;
                    else
                        supplyTransactionID = dbContext.Supply_Transaction.Max(r => r.Supply_Transaction_ID);
                    model.Supply_Transaction_ID = supplyTransactionID + 1;
                    await dbContext.Supply_Transaction.AddAsync(model);
                    await dbContext.SaveChangesAsync();

                    Stock_Model stock = new Stock_Model()
                    {
                        Branch_ID=model.Branch_ID,
                        In_QNT = model.QNT,
                        Item_Unit_ID = model.Item_Unit_ID,
                        Out_QNT = 0,
                        Stock_Notes = "",
                        Transaction_Type_ID = 4,
                        Time_Stamp = General.GetCurrentTime(),
                        User_Name = model.User_Name,
                        Transaction_ID = model.Supply_Transaction_ID
                    };
                    if (dbContext.Stock.Count() == 0)
                        stockId = 0;
                    else
                        stockId = dbContext.Stock.Max(r => r.Stock_ID);
                    stock.Stock_ID = stockId + 1;
                    await dbContext.Stock.AddAsync(stock);
                    await dbContext.SaveChangesAsync();

                    transaction.Commit();
                    return model;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public async Task<List<Supply_TransactionModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Supply_Transaction.AsQueryable();
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
        public async Task<Supply_TransactionModel> getByIdAsync(int supplyTransactionID)
        {
            return await dbContext.Supply_Transaction.FirstOrDefaultAsync(r => r.Supply_Transaction_ID == supplyTransactionID);
        }

        public async Task<Supply_TransactionModel?> updateAsync(int supplyTransactionID, Supply_TransactionModel model)
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    dbContext.Supply_Transaction.Update(model);
                    await dbContext.SaveChangesAsync();

                    Stock_Model stock = await dbContext.Stock.FirstAsync(r => r.Transaction_Type_ID == 4 && r.Transaction_ID == model.Supply_Transaction_ID);
                    if (stock != null)
                    {
                        stock.In_QNT = model.QNT;
                    }
                    dbContext.Stock.Update(stock);
                    dbContext.SaveChanges();
                    transaction.CommitAsync();
                    return model;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public async Task<Supply_TransactionModel?> deleteAsync(int supplyTransactionID)
        {
            var model = await dbContext.Supply_Transaction.FirstOrDefaultAsync(r => r.Supply_Transaction_ID == supplyTransactionID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Supply_Transaction.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<vSupply_TransactionModel>> getAllAsync(vSupplyTransactionCriteriaViewModel criteria)
        {
            DateTime dtFromDate;
            DateTime dtToDate;

            var query = dbContext.vSupply_Transaction.AsQueryable();
            if (criteria.Supply_Transaction_ID != null)
            {
                query = query.Where(r => r.Supply_Transaction_ID == criteria.Supply_Transaction_ID);
            }

            if (!string.IsNullOrEmpty(criteria.FromTransaction_Date))
            {
                dtFromDate = General.convertToDate(criteria.FromTransaction_Date);
                query = query.Where(r => r.Transaction_Date >= dtFromDate);
            }
            if (!string.IsNullOrEmpty(criteria.ToTransaction_Date))
            {
                dtToDate = General.convertToDate(criteria.ToTransaction_Date);
                query = query.Where(r => r.Transaction_Date < dtToDate.AddDays(1));
            }
            if (criteria.Source_ID != null)
            {
                query = query.Where(r => r.Source_ID == criteria.Source_ID);
            }
            if (!string.IsNullOrEmpty(criteria.Transaction_Notes))
            {
                query = query.Where(r => r.Transaction_Notes.Contains(criteria.Transaction_Notes.Trim()));
            }
            return await query.ToListAsync();

        }

        public async Task<vSupply_TransactionModel> getSupplyTransactionAsync(int supplyTransactionID)
        {
            return await dbContext.vSupply_Transaction.FirstOrDefaultAsync(r => r.Supply_Transaction_ID == supplyTransactionID);

        }
    }

}
