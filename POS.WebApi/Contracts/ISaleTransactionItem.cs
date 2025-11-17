using POS.Shared.Models;

namespace POS.WebApi.Contracts
{
    public interface ISaleTransactionItem
    {
        public Task<Sale_Transaction_Item_Model> createAsync(Sale_Transaction_Item_Model model);
        public Task<List<Sale_Transaction_Item_Model>> getAllAsync();
        public Task<Sale_Transaction_Item_Model> getByIdAsync(int saleTransactionItemId);
        public Task<Sale_Transaction_Item_Model?> deleteAsync(int saleTransactionItemId);
    }
}
