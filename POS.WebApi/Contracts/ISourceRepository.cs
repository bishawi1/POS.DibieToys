using POS.Shared.Models;
using POS.Shared.ViewModels;

namespace POS.WebApi.Contracts
{
    public interface ISourceRepository
    {
        public Task<SourceModel> createAsync(SourceModel model);
        public Task<List<SourceModel>> getAllAsync();
        public Task<SourceModel> getByIdAsync(Int16 sourceId);
        public Task<SourceModel?> updateAsync(Int16 sourceId, SourceModel model);
        public Task<SourceModel?> deleteAsync(Int16 sourceId);
        public Task<List<BookSourceQueryModel>> BookSourceQuery(BookSourceQueryCriteriaViewModel criteria);


    }
}
