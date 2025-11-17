using Microsoft.EntityFrameworkCore;
using POS.Shared.Models.Books;
using POS.WebApi.Contracts.Books;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories.Books
{
    public class SQLPublisherRepository : IPublisherRepository
    {
        private readonly DataContext dbContext;
        public SQLPublisherRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<PublisherModel> createAsync(PublisherModel model)
        {
            short publisherID;
            if (dbContext.Publisher.Count() == 0)
                publisherID = 0;
            else
                publisherID = dbContext.Publisher.Max(r => r.Publisher_ID);
            model.Publisher_ID = (short)(publisherID + 1);
            await dbContext.Publisher.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<PublisherModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Publisher.AsQueryable();
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
        public async Task<PublisherModel> getByIdAsync(short publisherID)
        {
            return await dbContext.Publisher.FirstOrDefaultAsync(r => r.Publisher_ID == publisherID);
        }
        public async Task<PublisherModel?> updateAsync(short publisherID, PublisherModel model)
        {
            dbContext.Publisher.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<PublisherModel?> deleteAsync(short publisherID)
        {
            var model = await dbContext.Publisher.FirstOrDefaultAsync(r => r.Publisher_ID == publisherID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Publisher.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
