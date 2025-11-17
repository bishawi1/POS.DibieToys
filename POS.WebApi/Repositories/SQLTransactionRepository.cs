using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLTransactionRepository : ITransaction
    {
        private readonly DataContext dbContext;

        public SQLTransactionRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Transaction_Model> createAsync(Transaction_Model model)
        {
            int transactionId = 0;
            if (dbContext.Transaction.Count() == 0)
            {
                transactionId = 0;
            }
            else
            {
                transactionId = dbContext.Transaction.Max(r => r.Transaction_ID); ;
            }
            model.Transaction_ID = transactionId + 1;
            await dbContext.Transaction.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<Transaction_Model?> deleteAsync(int transactionId)
        {
            var model = await dbContext.Transaction.FirstOrDefaultAsync(r => r.Transaction_ID == transactionId);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Transaction.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<Transaction_Model>> getAllAsync()
        {
            var qView = dbContext.Transaction.AsQueryable();
            return await qView.ToListAsync();
        }

        public async Task<Transaction_Model> getByIdAsync(int transactionId)
        {
            return await dbContext.Transaction.FirstOrDefaultAsync(r => r.Transaction_ID == transactionId);
        }

        public async Task<Transaction_Model?> updateAsync(int transactionId, Transaction_Model model)
        {
            dbContext.Transaction.Update(model);
            await dbContext.SaveChangesAsync();
            return model;

        }
    }
}
