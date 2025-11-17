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
    public class SQLCityRepository : ICityRepository
    {
        private readonly DataContext dbContext;

        public SQLCityRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<CityModel> createAsync(CityModel model)
        {
            model.City_ID = (byte)(dbContext.Cities.Max(r => r.City_ID) + 1);
            await dbContext.Cities.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<CityModel?> deleteAsync(byte cityId)
        {
            var model = await dbContext.Cities.FirstOrDefaultAsync(r => r.City_ID == cityId);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Cities.Remove(model);
                dbContext.SaveChanges();
            }
            return model;
        }

        public async Task<List<CityModel>> getAllAsync()
        {
            return await dbContext.Cities.ToListAsync();
        }

        public async Task<CityModel> getByIdAsync(byte cityId)
        {
            return await dbContext.Cities.FirstOrDefaultAsync(r => r.City_ID == cityId);
        }

        public async Task<CityModel?> updateAsync(byte cityId, CityModel model)
        {
            dbContext.Cities.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
    }

}
