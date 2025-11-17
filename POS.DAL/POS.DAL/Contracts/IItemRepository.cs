using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Contracts
{
    public interface IItemRepository
    {
        public Task<ItemModel> createAsync(AddItemRequestModel model);
        public Task<List<ItemModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<ItemModel> getByIdAsync(int itemID);
        public Task<ItemModel?> updateAsync(UpdateItemRequestModel model);
        public Task<ItemModel?> deleteAsync(int itemID);
    }
}
