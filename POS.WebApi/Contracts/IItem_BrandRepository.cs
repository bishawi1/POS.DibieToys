using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.WebApi.Contracts
{
    public interface IItem_BrandRepository
    {
        public Task<Item_BrandModel> createAsync(Item_BrandModel model);
        public Task<List<Item_BrandModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<Item_BrandModel> getByIdAsync(int itemBrandID);
        public Task<Item_BrandModel?> updateAsync(int itemBrandID, Item_BrandModel model);
        public Task<Item_BrandModel?> deleteAsync(int itemBrandID);
    }

}
