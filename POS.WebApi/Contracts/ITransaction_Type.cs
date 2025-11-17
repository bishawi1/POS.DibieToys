using POS.Shared.Models;

namespace POS.WebApi.Contracts
{
    public interface ITransaction_Type
    {
        public Task<Transaction_Type_Model> createAsync(Transaction_Type_Model model);
        public Task<List<Transaction_Type_Model>> getAllAsync();
        public Task<Transaction_Type_Model> getByIdAsync(int transactionTypeId);
        public Task<Transaction_Type_Model?> updateAsync(int stockId, Transaction_Type_Model model);
        public Task<Transaction_Type_Model?> deleteAsync(int transactionTypeId);

    }
}
