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
    public class SQLItem_UnitRepository : IItem_UnitRepository
    {
        private readonly DataContext dbContext;
        public SQLItem_UnitRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Item_UnitModel> createAsync(Item_UnitModel model)
        {
            int itemUnitID = dbContext.Item_Unit.Max(r => r.Unit_ID);
            model.Unit_ID = (byte)(itemUnitID + 1);
            await dbContext.Item_Unit.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<Item_UnitModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Item_Unit.AsQueryable();
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
        public async Task<Item_UnitModel> getByIdAsync(short itemUnitID)
        {
            return await dbContext.Item_Unit.FirstOrDefaultAsync(r => r.Unit_ID == itemUnitID);
        }
        public async Task<Item_UnitModel?> updateAsync(Item_UnitModel model)
        {
            dbContext.Item_Unit.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<Item_UnitModel?> deleteAsync(short itemUnitID)
        {
            var model = await dbContext.Item_Unit.FirstOrDefaultAsync(r => r.Unit_ID == itemUnitID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Item_Unit.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
