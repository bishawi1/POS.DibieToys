using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLBankRepository : IBankRepository
    {
        private readonly DataContext dbContext;
        public SQLBankRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<BankModel> createAsync(BankModel model)
        {
            int bankNo;
            if (dbContext.Bank.Count() == 0)
            {
                bankNo = 0;
            }
            else
            {
                bankNo = dbContext.Bank.Max(r => r.Bank_No); ;
            }
            model.Bank_No = Convert.ToByte(bankNo + 1);
            await dbContext.Bank.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<BankModel>> getAllAsync()
        {
            var qView = dbContext.Bank.AsQueryable();
                return await qView.ToListAsync();
        }
        public async Task<BankModel> getByIdAsync(byte bankNo)
        {
            return await dbContext.Bank.FirstOrDefaultAsync(r => r.Bank_No == bankNo);
        }
        public async Task<BankModel?> updateAsync(byte bankNo, BankModel model)
        {
            dbContext.Bank.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<BankModel?> deleteAsync(byte bankNo)
        {
            var model = await dbContext.Bank.FirstOrDefaultAsync(r => r.Bank_No == bankNo);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Bank.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
