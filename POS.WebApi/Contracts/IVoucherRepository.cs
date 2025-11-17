using POS.Shared.Models;
using POS.Shared.ViewModels;

namespace POS.WebApi.Contracts
{
    public interface IVoucherRepository
    {
        public Task<VoucherModel> createAsync(VoucherModel model);
        public Task<List<VoucherModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<VoucherModel> getByIdAsync(int voucherID);
        public Task<VoucherModel?> updateAsync(int voucherID, VoucherModel model);
        public Task<VoucherModel?> deleteAsync(int voucherID);
        public Task<List<vVoucherModel>?> getVoucherQuery(VoucherQueryCriteriaViewModel criteria);
        public Task<List<VoucherTotalViewModel>?> getVoucherSummary(VoucherQueryCriteriaViewModel criteria);
        public Task<List<vPurchase_Invoice_Model>?> getPurchaseInvoiceQuery(PurchaseInvoiceQueryCriteriaViewModel criteria);
    }
}
