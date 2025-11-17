using Microsoft.EntityFrameworkCore;
using POS.DAL.Contracts;
using POS.DAL.Data;
using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Repositories
{
    public class SQLCurrency_RateRepository : ICurrency_RateRepository
    {
        private readonly DataContext dbContext;
        public SQLCurrency_RateRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Currency_RateModel> createAsync(Currency_RateModel model)
        {
            int currencyRateID = dbContext.Currency_Rate.Max(r => r.Currency_ID);
            model.Currency_ID = (byte)(currencyRateID + 1);
            await dbContext.Currency_Rate.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<Currency_RateModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Currency_Rate.AsQueryable();
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
        public async Task<Currency_RateModel> getByIdAsync(int currencyRateID)
        {
            return await dbContext.Currency_Rate.FirstOrDefaultAsync(r => r.Currency_ID == currencyRateID);
        }
        public async Task<Currency_RateModel?> updateAsync(int currencyRateID, Currency_RateModel model)
        {
            dbContext.Currency_Rate.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<Currency_RateModel?> deleteAsync(int currencyRateID)
        {
            var model = await dbContext.Currency_Rate.FirstOrDefaultAsync(r => r.Currency_ID == currencyRateID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Currency_Rate.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
