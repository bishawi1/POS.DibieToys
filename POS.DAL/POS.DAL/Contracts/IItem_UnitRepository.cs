using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Contracts
{
    public interface IItem_UnitRepository
    {
        public Task<Item_UnitModel> createAsync(Item_UnitModel model);
        public Task<List<Item_UnitModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<Item_UnitModel> getByIdAsync(short itemUnitID);
        public Task<Item_UnitModel?> updateAsync(Item_UnitModel model);
        public Task<Item_UnitModel?> deleteAsync(short itemUnitID);
    }

}
