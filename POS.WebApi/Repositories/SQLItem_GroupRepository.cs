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
    public class SQLItem_GroupRepository : IItem_GroupRepository
    {
        private readonly DataContext dbContext;
        public SQLItem_GroupRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Item_GroupModel> createAsync(Item_GroupModel model)
        {
            int itemGroupID = dbContext.Item_Group.Max(r => r.Item_Group_ID);
            model.Item_Group_ID = (short)(itemGroupID + 1);
            model.Item_Group_No = model.Item_Group_ID.ToString();
            await dbContext.Item_Group.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<Item_GroupModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Item_Group.AsQueryable();
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
        public async Task<Item_GroupModel> getByIdAsync(short itemGroupID)
        {
            return await dbContext.Item_Group.FirstOrDefaultAsync(r => r.Item_Group_ID == itemGroupID);
        }
        public async Task<Item_GroupModel?> updateAsync(short itemGroupID, Item_GroupModel model)
        {
            dbContext.Item_Group.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<Item_GroupModel?> deleteAsync(short itemGroupID)
        {
            var model = await dbContext.Item_Group.FirstOrDefaultAsync(r => r.Item_Group_ID == itemGroupID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Item_Group.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<Item_GroupModel>> getSubItemGroupsAsync(short parentItemGroupID)
        {
            return await dbContext.Item_Group.Where(r => r.Parent_Item_Group_ID == parentItemGroupID).ToListAsync();
        }
    }

}
