using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Contracts
{
    public interface ICityRepository
    {
        public Task<CityModel> createAsync(CityModel model);
        public Task<List<CityModel>> getAllAsync();
        public Task<CityModel> getByIdAsync(byte cityId);
        public Task<CityModel?> updateAsync(byte cityId, CityModel model);
        public Task<CityModel?> deleteAsync(byte cityId);
    }
}
