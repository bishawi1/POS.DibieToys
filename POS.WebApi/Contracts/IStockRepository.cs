using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;

namespace POS.WebApi.Contracts
{
    public interface IStockRepository
    {
        public Task<Stock_Model> createAsync(Stock_Model model);
        public Task<List<Stock_Model>> getAllAsync();
        public Task<List<vStockModel>> getAllAsync(vStockQueryCriteriaViewModel criteria);
        public Task<Stock_Model> getByIdAsync(int stockId);
        public Task<Stock_Model?> updateAsync(int stockId, Stock_Model model);
        public Task<Stock_Model?> deleteAsync(int stockId);

        public Task<List<vStockModel>> GetStockDetails(stockDetailsCriteriaViewModel criteria);

    }
}
