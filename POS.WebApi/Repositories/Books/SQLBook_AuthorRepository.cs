using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.WebApi.Contracts.Books;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories.Books
{
    public class SQLBook_AuthorRepository : IBook_AuthorRepository
    {
        private readonly DataContext dbContext;
        public SQLBook_AuthorRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Book_AuthorModel> createAsync(Book_AuthorModel model)
        {
            int bookAuthorID;
            if (dbContext.Book_Author.Count() == 0)
                bookAuthorID = 0;
            else
                bookAuthorID = dbContext.Book_Author.Max(r => r.Book_Author_ID);
            model.Book_Author_ID = bookAuthorID + 1;

            await dbContext.Book_Author.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<Book_AuthorModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Book_Author.AsQueryable();
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
        public async Task<Book_AuthorModel> getByIdAsync(int bookAuthorID)
        {
            return await dbContext.Book_Author.FirstOrDefaultAsync(r => r.Book_Author_ID == bookAuthorID);
        }
        public async Task<Book_AuthorModel?> updateAsync(int bookAuthorID, Book_AuthorModel model)
        {
            dbContext.Book_Author.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<Book_AuthorModel?> deleteAsync(int bookAuthorID)
        {
            var model = await dbContext.Book_Author.FirstOrDefaultAsync(r => r.Book_Author_ID == bookAuthorID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Book_Author.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
