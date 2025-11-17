using POS.Shared.Models.Books;

namespace POS.WebApi.Contracts.Books
{
    public interface IBook_SubjectRepository
    {
        public Task<Book_SubjectModel> createAsync(Book_SubjectModel model);
        public Task<List<Book_SubjectModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<Book_SubjectModel> getByIdAsync(int bookSubjectID);
        public Task<Book_SubjectModel?> updateAsync(int bookSubjectID, Book_SubjectModel model);
        public Task<Book_SubjectModel?> deleteAsync(int bookSubjectID);
    }

}
