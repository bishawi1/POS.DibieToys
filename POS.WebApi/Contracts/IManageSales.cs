using POS.Shared.DTOs;
using POS.Shared.Models;

namespace POS.WebApi.Contracts
{
    public interface IManageSales
    {
        public Task<Sale_Transaction_Model> createAsync(AddSaleTransactionDto model);

    }
}
