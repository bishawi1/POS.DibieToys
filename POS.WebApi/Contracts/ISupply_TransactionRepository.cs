using POS.Shared.Models;
using POS.Shared.ViewModels;

namespace POS.WebApi.Contracts
{
    public interface ISupply_TransactionRepository
    {
        public Task<Supply_TransactionModel> createAsync(Supply_TransactionModel model);
        public Task<List<Supply_TransactionModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<List<vSupply_TransactionModel>> getAllAsync(vSupplyTransactionCriteriaViewModel criteria);
        public Task<Supply_TransactionModel> getByIdAsync(int supplyTransactionID);
        public Task<vSupply_TransactionModel> getSupplyTransactionAsync(int supplyTransactionID);
        public Task<Supply_TransactionModel?> updateAsync(int supplyTransactionID, Supply_TransactionModel model);
        public Task<Supply_TransactionModel?> deleteAsync(int supplyTransactionID);
    }
}
