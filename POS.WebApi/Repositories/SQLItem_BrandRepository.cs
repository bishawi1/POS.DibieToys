using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.WebApi.Contracts;
using POS.WebApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.WebApi.Repositories
{
    public class SQLItem_BrandRepository : IItem_BrandRepository
    {
        private readonly DataContext dbContext;
        public SQLItem_BrandRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Item_BrandModel> createAsync(Item_BrandModel model)
        {
            int itemBrandID = dbContext.Item_Brand.Max(r => r.Item_Brand_ID);
            model.Item_Brand_ID = itemBrandID + 1;
            await dbContext.Item_Brand.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<Item_BrandModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Item_Brand.AsQueryable();
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
        public async Task<Item_BrandModel> getByIdAsync(int itemBrandID)
        {
            return await dbContext.Item_Brand.FirstOrDefaultAsync(r => r.Item_Brand_ID == itemBrandID);
        }
        public async Task<Item_BrandModel?> updateAsync(int itemBrandID, Item_BrandModel model)
        {
            dbContext.Item_Brand.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<Item_BrandModel?> deleteAsync(int itemBrandID)
        {
            var model = await dbContext.Item_Brand.FirstOrDefaultAsync(r => r.Item_Brand_ID == itemBrandID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Item_Brand.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
