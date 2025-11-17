using POS.Shared.Models;

namespace POS.WebApi.Contracts
{
    public interface ITransaction
    {
        public Task<Transaction_Model> createAsync(Transaction_Model model);
        public Task<List<Transaction_Model>> getAllAsync();
        public Task<Transaction_Model> getByIdAsync(int transactionId);
        public Task<Transaction_Model?> updateAsync(int transactionId, Transaction_Model model);

        public Task<Transaction_Model?> deleteAsync(int transactionId);
    }
}
