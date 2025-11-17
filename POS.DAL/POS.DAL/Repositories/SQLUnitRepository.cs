using Microsoft.EntityFrameworkCore;
using POS.DAL.Contracts;
using POS.DAL.Data;
using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Repositories
{
    public class SQLUnitRepository : IUnitRepository
    {
        private readonly DataContext dbContext;
        public SQLUnitRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<UnitModel> createAsync(UnitModel model)
        {
            int unitID = dbContext.Unit.Max(r => r.Unit_ID);
            model.Unit_ID = (byte)(unitID + 1);
            await dbContext.Unit.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<UnitModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Unit.AsQueryable();
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
        public async Task<UnitModel> getByIdAsync(byte unitID)
        {
            return await dbContext.Unit.FirstOrDefaultAsync(r => r.Unit_ID == unitID);
        }
        public async Task<UnitModel?> updateAsync(byte unitID, UnitModel model)
        {
            dbContext.Unit.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<UnitModel?> deleteAsync(byte unitID)
        {
            var model = await dbContext.Unit.FirstOrDefaultAsync(r => r.Unit_ID == unitID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Unit.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
