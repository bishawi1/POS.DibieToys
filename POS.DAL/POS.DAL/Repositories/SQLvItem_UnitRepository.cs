using Microsoft.EntityFrameworkCore;
using POS.DAL.Contracts;
using POS.DAL.Data;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Repositories
{
    public class SQLvItem_UnitRepository : IvItem_UnitRepository
    {
        private readonly DataContext dbContext;
        public SQLvItem_UnitRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<vItem_UnitModel> createAsync(vItem_UnitModel model)
        {
            int itemStatusID = (int)dbContext.vItem_Unit.Max(r => r.Item_Status_ID);
            model.Item_Status_ID = (byte?)(itemStatusID + 1);
            await dbContext.vItem_Unit.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<vItem_UnitModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.vItem_Unit.AsQueryable();
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
        public async Task<List<vItem_UnitModel>> getAllAsync(ItemListCriteriaViewModel criteria)
        {
            var qView = dbContext.vItem_Unit.AsQueryable();
            if(criteria != null)
            {
                if(criteria.Item_Group_ID!= null)
                {
                    qView = qView.Where(r => r.Item_Group_ID == criteria.Item_Group_ID);
                }
                if (!string.IsNullOrEmpty(criteria.Barcode))
                {
                    qView = qView.Where(r => r.Barcode.Equals(criteria.Barcode));
                }
                if (!string.IsNullOrEmpty(criteria.Item_Desc))
                {
                    qView = qView.Where(r => r.Item_Desc.Contains(criteria.Item_Desc, StringComparison.OrdinalIgnoreCase));
                }
                if(criteria.Item_ID != null)
                {
                    qView = qView.Where(r => r.Item_ID.Equals(criteria.Item_ID));
                }
            }
            try
            {
                return await qView.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
            return await qView.ToListAsync();
        }

        public async Task<vItem_UnitModel> getByIdAsync(short itemID)
        {
            return await dbContext.vItem_Unit.FirstOrDefaultAsync(r => r.Item_ID == itemID);
        }
        public async Task<vItem_UnitModel?> updateAsync(short itemStatusID, vItem_UnitModel model)
        {
            dbContext.vItem_Unit.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<vItem_UnitModel?> deleteAsync(short itemStatusID)
        {
            var model = await dbContext.vItem_Unit.FirstOrDefaultAsync(r => r.Item_Status_ID == itemStatusID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.vItem_Unit.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
