using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.WebApi.Contracts
{
    public interface IvItem_UnitRepository
    {
        public Task<string> generateBarcode();
        public Task<vItem_UnitModel> createAsync(vItem_UnitModel model);
        public Task<List<vItem_UnitModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<List<vItem_UnitModel>> getAllAsync(ItemListCriteriaViewModel criteria);
        public Task<List<vBranch_Item_UnitModel>> getAllAsync(Branch_ItemListCriteriaViewModel criteria);
        public Task<vItem_UnitModel> getByIdAsync(short itemStatusID);
        public Task<vItem_UnitModel?> updateAsync(short itemStatusID, vItem_UnitModel model);
        public Task<vItem_UnitModel?> deleteAsync(short itemStatusID);
    }

}
