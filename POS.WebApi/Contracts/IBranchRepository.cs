using POS.Shared.Models;
using POS.Shared.Models.Books;

namespace POS.WebApi.Contracts
{
    public interface IBranchRepository
    {
        public Task<Branch_Model> createAsync(Branch_Model model);
        public Task<List<Branch_Model>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<Branch_Model> getByIdAsync(byte branchId);
        public Task<Branch_Model?> updateAsync(byte branchId, Branch_Model model);
        public Task<Branch_Model?> deleteAsync(byte branchId);
    }
}
