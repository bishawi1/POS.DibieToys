using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLTransactionTypeRepository: ITransaction_Type
    {
        private readonly DataContext dbContext;

        public SQLTransactionTypeRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Transaction_Type_Model> createAsync(Transaction_Type_Model model)
        {
            int transactionTypeId = dbContext.Transaction_Type.Max(r => r.Transaction_Type_ID);
            model.Transaction_Type_ID = transactionTypeId + 1;
            await dbContext.Transaction_Type.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<Transaction_Type_Model?> deleteAsync(int transactionTypeId)
        {

            var model = await dbContext.Transaction_Type.FirstOrDefaultAsync(r => r.Transaction_Type_ID == transactionTypeId);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Transaction_Type.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<Transaction_Type_Model>> getAllAsync()
        {
            var qView = dbContext.Transaction_Type.AsQueryable();
            return await qView.ToListAsync();
        }

        public async Task<Transaction_Type_Model> getByIdAsync(int transactionTypeId)
        {
            return await dbContext.Transaction_Type.FirstOrDefaultAsync(r => r.Transaction_Type_ID == transactionTypeId);

        }

        public async Task<Transaction_Type_Model?> updateAsync(int stockId, Transaction_Type_Model model)
        {
            dbContext.Transaction_Type.Update(model);
            await dbContext.SaveChangesAsync();
            return model;

    }
}
}
