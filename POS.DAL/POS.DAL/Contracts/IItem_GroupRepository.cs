using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Contracts
{
    public interface IItem_GroupRepository
    {
        public Task<Item_GroupModel> createAsync(Item_GroupModel model);
        public Task<List<Item_GroupModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<Item_GroupModel> getByIdAsync(short itemGroupID);
        public Task<List<Item_GroupModel>> getSubItemGroupsAsync(short parentItemGroupID);
        public Task<Item_GroupModel?> updateAsync(short itemGroupID, Item_GroupModel model);
        public Task<Item_GroupModel?> deleteAsync(short itemGroupID);
    }

}
