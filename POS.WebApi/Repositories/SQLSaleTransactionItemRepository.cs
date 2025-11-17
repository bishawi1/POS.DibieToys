using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLSaleTransactionItemRepository : ISaleTransactionItem
    {
        private readonly DataContext dbContext;

        public SQLSaleTransactionItemRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Sale_Transaction_Item_Model> createAsync(Sale_Transaction_Item_Model model)
        {
            int saleTransactionItemId = dbContext.Sale_Transaction_Item.Max(r => r.Sale_Transaction_Item_ID);
            model.Sale_Transaction_Item_ID = saleTransactionItemId + 1;
            await dbContext.Sale_Transaction_Item.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<Sale_Transaction_Item_Model?> deleteAsync(int saleTransactionItemId)
        {
            var model = await dbContext.Sale_Transaction_Item.FirstOrDefaultAsync(r => r.Sale_Transaction_Item_ID == saleTransactionItemId);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Sale_Transaction_Item.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
        

        public async Task<List<Sale_Transaction_Item_Model>> getAllAsync()
        {
            var qView = dbContext.Sale_Transaction_Item.AsQueryable();
            return await qView.ToListAsync();
        }

        public async Task<Sale_Transaction_Item_Model> getByIdAsync(int saleTransactionItemId)
        {
            return await dbContext.Sale_Transaction_Item.FirstOrDefaultAsync(r => r.Sale_Transaction_Item_ID == saleTransactionItemId);
        }
    }
}
