using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.WebApi.Contracts
{
    public interface ICurrencyRepository
    {
        public Task<CurrencyModel> createAsync(CurrencyModel model);
        public Task<List<CurrencyModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<CurrencyModel> getByIdAsync(byte currencyID);
        public Task<CurrencyModel?> updateAsync(byte currencyID, CurrencyModel model);
        public Task<CurrencyModel?> deleteAsync(byte currencyID);
    }

}
