using Microsoft.EntityFrameworkCore;
using POS.Shared.Models.Books;
using POS.WebApi.Contracts.Books;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories.Books
{
    public class SQLBook_SubjectRepository : IBook_SubjectRepository
    {
        private readonly DataContext dbContext;
        public SQLBook_SubjectRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Book_SubjectModel> createAsync(Book_SubjectModel model)
        {
            int bookSubjectID;
            if (dbContext.Book_Subject.Count() == 0)
                bookSubjectID = 0;
            else
                bookSubjectID = dbContext.Book_Subject.Max(r => r.Book_Subject_ID);
            model.Book_Subject_ID = bookSubjectID + 1;
            await dbContext.Book_Subject.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<Book_SubjectModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Book_Subject.AsQueryable();
            if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    //qView = qView.Where(r => r. Book_Author_Desc.Contains(filterQuery));
                }
            }
            if (pageSize == 0)
            {
                return await qView.ToListAsync();
            }
            else
            {
                var skipResults = (pageNumber - 1) * pageSize;
                return await qView.Skip(skipResults).Take(pageSize).ToListAsync();
            }
        }
        public async Task<Book_SubjectModel> getByIdAsync(int bookSubjectID)
        {
            return await dbContext.Book_Subject.FirstOrDefaultAsync(r => r.Book_Subject_ID == bookSubjectID);
        }
        public async Task<Book_SubjectModel?> updateAsync(int bookSubjectID, Book_SubjectModel model)
        {
            dbContext.Book_Subject.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<Book_SubjectModel?> deleteAsync(int bookSubjectID)
        {
            var model = await dbContext.Book_Subject.FirstOrDefaultAsync(r => r.Book_Subject_ID == bookSubjectID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Book_Subject.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
