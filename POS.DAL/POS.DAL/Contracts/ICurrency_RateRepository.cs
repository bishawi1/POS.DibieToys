using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Contracts
{
    public interface ICurrency_RateRepository
    {
        public Task<Currency_RateModel> createAsync(Currency_RateModel model);
        public Task<List<Currency_RateModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<Currency_RateModel> getByIdAsync(int currencyRateID);
        public Task<Currency_RateModel?> updateAsync(int currencyRateID, Currency_RateModel model);
        public Task<Currency_RateModel?> deleteAsync(int currencyRateID);
    }

}
