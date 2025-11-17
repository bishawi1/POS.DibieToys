using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;

namespace POS.WebApi.Contracts
{
    public interface ISaleTransaction
    {
        public Task<Sale_Transaction_Model> createAsync(Sale_Transaction_Model model);
        public Task<Sale_Transaction_Model> addSaleAsync(AddSaleTransactionDto model);
        public Task<Sale_Transaction_Model> updateSaleAsync(UpdateSaleTransactionDto model);
        public Task<List<Sale_Transaction_Model>> getAllAsync();
        public Task<Sale_Transaction_Model> getByIdAsync(int saleTransactionId);
        public Task<Sale_Transaction_Model?> updateAsync(int saleTransactionId, Sale_Transaction_Model model);
        public Task<Sale_Transaction_Model?> deleteAsync(int saleTransactionId);
        public Task<List<vSales_TransactonModel>> getAllAsync(SalesQueryCriteriaViewModel criteria);
        public Task<List<vInvoiceReportModel>> getInvoiceReportDataAsync(InvoiceReportCriteriaViewModel criteria);
    }
}
