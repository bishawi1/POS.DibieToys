using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Contracts
{
    public interface IUnitRepository
    {
        public Task<UnitModel> createAsync(UnitModel model);
        public Task<List<UnitModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<UnitModel> getByIdAsync(byte unitID);
        public Task<UnitModel?> updateAsync(byte unitID, UnitModel model);
        public Task<UnitModel?> deleteAsync(byte unitID);
    }

}
