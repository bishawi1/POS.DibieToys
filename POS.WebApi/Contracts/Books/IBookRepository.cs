using POS.Shared.Models;
using POS.Shared.Models.Books;
using POS.Shared.ViewModels;
using POS.Shared.ViewModels.Books;

namespace POS.WebApi.Contracts.Books
{
    public interface IBookRepository
    {
        public Task<BookModel> createAsync(BookModel model, decimal itemUnitPrice, decimal itemUnitCost, int qnt, string barcode, IItemRepository itemRepository);
        public Task<List<BookModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<List<vBooksModel>> getAllAsync(vBookQueryCriteriaViewModel criteria);

        public Task<BookModel> getByIdAsync(int bookID);
        public Task<vBooksModel> getBookAsync(int bookId);
        public Task<BookModel?> updateAsync(int bookID, BookModel model, decimal itemUnitPrice, decimal itemUnitCost, IItemRepository itemRepository);
        public Task<BookModel?> deleteAsync(int bookID);
        public Task<Item_UnitModel> getBookItemUnit(int bookId);
    }

}
