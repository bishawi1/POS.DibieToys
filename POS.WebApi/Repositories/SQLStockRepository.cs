using Microsoft.EntityFrameworkCore;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLStockRepository : IStockRepository
    {
        private readonly DataContext dbContext;

        public SQLStockRepository(DataContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public async Task<Stock_Model> createAsync(Stock_Model model)
        {
            int stockId = 0;
            if (dbContext.Stock.Count() == 0)
            {
                stockId = 0;
            }
            else
            {
                stockId= dbContext.Stock.Max(r => r.Stock_ID);
            }
            
            model.Stock_ID = stockId + 1;
            await dbContext.Stock.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }


        public async Task<Stock_Model?> deleteAsync(int stockId)
        {
            var model = await dbContext.Stock.FirstOrDefaultAsync(r => r.Stock_ID == stockId);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Stock.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<Stock_Model>> getAllAsync()
        {
            var qView = dbContext.Stock.AsQueryable();
            return await qView.ToListAsync();
        }

        public async Task<List<vStockModel>> getAllAsync(vStockQueryCriteriaViewModel criteria)
        {
            var qView = dbContext.vStock.AsQueryable();
            if (criteria != null)
            {
                if (criteria.Branch_ID != null)
                {
                    qView = qView.Where(r => r.Branch_ID == criteria.Branch_ID);
                }
                if (!string.IsNullOrEmpty(criteria.Barcode))
                {
                    qView = qView.Where(r => r.Barcode.Equals(criteria.Barcode));
                }
                if (!string.IsNullOrEmpty(criteria.Item_Desc))
                {
                    qView = qView.Where(r => EF.Functions.Like(r.Item_Desc, "%" + criteria.Item_Desc.Trim().Replace(" ", "%") + "%"));
                    //qView = qView.Where(r => r.Item_Desc.Contains(criteria.Item_Desc));
                }
                if (criteria.Stock_ID != null)
                {
                    qView = qView.Where(r => r.Stock_ID.Equals(criteria.Stock_ID));
                }
                if (criteria.Item_Unit_ID != null)
                {
                    qView = qView.Where(r => r.Item_Unit_ID.Equals(criteria.Item_Unit_ID));
                }
            }
            try
            {
                return await qView.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
            return await qView.ToListAsync();
        }

        public async Task<Stock_Model> getByIdAsync(int stockId)
        {
            return await dbContext.Stock.FirstOrDefaultAsync(r => r.Stock_ID == stockId);
        }

        public async Task<List<vStockModel>> GetStockDetails(stockDetailsCriteriaViewModel criteria)
        {
            var qView = dbContext.vStock.AsQueryable();
            if (criteria != null)
            {
                if (criteria.Item_Unit_ID != null)
                {
                    if(criteria.Item_Unit_ID>0)
                        qView = qView.Where(r => r.Item_Unit_ID == criteria.Item_Unit_ID);
                }
                if (criteria.Stock_ID != null)
                {
                    if (criteria.Stock_ID>0)
                        qView = qView.Where(r => r.Stock_ID.Equals(criteria.Stock_ID));
                }
            }
            try
            {
                return await qView.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Stock_Model?> updateAsync(int stockId, Stock_Model model)
        {
            dbContext.Stock.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
    }
}
