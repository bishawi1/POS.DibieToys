using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLSourceRepository : ISourceRepository
    {
        private readonly DataContext dbContext;

        public SQLSourceRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<BookSourceQueryModel>> BookSourceQuery(BookSourceQueryCriteriaViewModel criteria)
        {
            var query = dbContext.BookSourceQuery.AsQueryable();
            if (!string.IsNullOrEmpty(criteria.User_Name))
                query = query.Where(r => r.User_Name == criteria.User_Name);
            if (criteria.FromInvoiceDate != null)
                query = query.Where(r => r.Invoice_Date >= General.convertToDate(criteria.FromInvoiceDate));
            if (criteria.ToInvoiceDate != null)
                query = query.Where(r => r.Invoice_Date <= General.convertToDate(criteria.ToInvoiceDate));
            if (criteria.Book_ID != null)
                query = query.Where(r => r.Book_ID == criteria.Book_ID);
            if (criteria.Source_ID != null)
                query = query.Where(r => r.Source_ID == criteria.Source_ID);

            return await query.ToListAsync();
        }

        public async Task<SourceModel> createAsync(SourceModel model)
        {
            model.Book_Source_ID = (Int16)(dbContext.Sources.Max(r => r.Book_Source_ID) + 1);
            await dbContext.Sources.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<SourceModel?> deleteAsync(short sourceId)
        {
            var model = await dbContext.Sources.FirstOrDefaultAsync(r => r.Book_Source_ID == sourceId);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Sources.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<SourceModel>> getAllAsync()
        {
            return await dbContext.Sources.ToListAsync();
        }

        public async Task<SourceModel> getByIdAsync(short sourceId)
        {
            return await dbContext.Sources.FirstOrDefaultAsync(r => r.Book_Source_ID == sourceId);
        }

        public async Task<SourceModel?> updateAsync(short sourceId, SourceModel model)
        {
            dbContext.Sources.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
    }

}
