using POS.Shared.Models;

namespace POS.WebApi.Contracts.Books
{
    public interface IBook_AuthorRepository
    {
        public Task<Book_AuthorModel> createAsync(Book_AuthorModel model);
        public Task<List<Book_AuthorModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<Book_AuthorModel> getByIdAsync(int bookAuthorID);
        public Task<Book_AuthorModel?> updateAsync(int bookAuthorID, Book_AuthorModel model);
        public Task<Book_AuthorModel?> deleteAsync(int bookAuthorID);
    }

}
