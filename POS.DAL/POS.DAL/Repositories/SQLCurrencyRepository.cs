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
    public class SQLCurrencyRepository : ICurrencyRepository
    {
        private readonly DataContext dbContext;
        public SQLCurrencyRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<CurrencyModel> createAsync(CurrencyModel model)
        {
            int currencyID = dbContext.Currency.Max(r => r.Currency_ID);
            model.Currency_ID = (byte)(currencyID + 1);
            await dbContext.Currency.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<CurrencyModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Currency.AsQueryable();
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
        public async Task<CurrencyModel> getByIdAsync(byte currencyID)
        {
            return await dbContext.Currency.FirstOrDefaultAsync(r => r.Currency_ID == currencyID);
        }
        public async Task<CurrencyModel?> updateAsync(byte currencyID, CurrencyModel model)
        {
            dbContext.Currency.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<CurrencyModel?> deleteAsync(byte currencyID)
        {
            var model = await dbContext.Currency.FirstOrDefaultAsync(r => r.Currency_ID == currencyID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Currency.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
