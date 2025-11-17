using POS.Shared.Models.Books;

namespace POS.WebApi.Contracts.Books
{
    public interface IPublisherRepository
    {
        public Task<PublisherModel> createAsync(PublisherModel model);
        public Task<List<PublisherModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<PublisherModel> getByIdAsync(short publisherID);
        public Task<PublisherModel?> updateAsync(short publisherID, PublisherModel model);
        public Task<PublisherModel?> deleteAsync(short publisherID);
    }

}
