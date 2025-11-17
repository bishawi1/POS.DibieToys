using Microsoft.EntityFrameworkCore;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.WebApi.Contracts;
using POS.WebApi.Data;
using System.Security.Policy;

namespace POS.WebApi.Repositories
{
    public class SQLBranchRepository : IBranchRepository
    {
        private readonly DataContext dbContext;

        public SQLBranchRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Branch_Model> createAsync(Branch_Model model)
        {
            byte branchId;
            if (dbContext.Branch.Count() == 0)
                branchId = 0;
            else
                branchId = dbContext.Branch.Max(r => r.Branch_ID);
            model.Branch_ID = (byte)(branchId + 1);
            await dbContext.Branch.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<Branch_Model?> deleteAsync(byte branchId)
        {
            var model = await dbContext.Branch.FirstOrDefaultAsync(r => r.Branch_ID == branchId);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Branch.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;

        }

        public async Task<List<Branch_Model>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Branch.AsQueryable();
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

        public async Task<Branch_Model> getByIdAsync(byte branchId)
        {
            return await dbContext.Branch.FirstOrDefaultAsync(r => r.Branch_ID == branchId);
        }

        public async Task<Branch_Model?> updateAsync(byte branchId, Branch_Model model)
        {
            dbContext.Branch.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
    }
}
