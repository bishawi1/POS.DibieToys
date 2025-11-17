using Microsoft.EntityFrameworkCore;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLTellerRepository : ITellerRepository
    {
        private readonly DataContext dbContext;
        public SQLTellerRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<TellerModel> createAsync(TellerModel model)
        {
            int tellerID;
            if (dbContext.Teller.Count() == 0)
            {
                tellerID = 0;
            }
            else
            {
                tellerID = dbContext.Teller.Max(r => r.Teller_ID);
            }

            model.Teller_ID = tellerID + 1;
            await dbContext.Teller.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<TellerModel>> getAllAsync()
        {
            var qView = dbContext.Teller.AsQueryable();
            return await qView.ToListAsync();
        }
        public async Task<TellerModel> getByIdAsync(int tellerID)
        {
            return await dbContext.Teller.FirstOrDefaultAsync(r => r.Teller_ID == tellerID);
        }
        public async Task<TellerModel?> updateAsync(TellerModel model)
        {
            dbContext.Teller.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<TellerModel?> deleteAsync(int tellerID)
        {
            var model = await dbContext.Teller.FirstOrDefaultAsync(r => r.Teller_ID == tellerID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Teller.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<Teller_UserModel> getByUserAsync(string tellerUserName)
        {
            var model = await dbContext.Teller_User.FirstOrDefaultAsync(r => r.User_Name == tellerUserName);
            //ResultModel result = new ResultModel()
            //{
            //    Data = model,
            //    StatusCode = "200",
            //    ErrorText=""
            //};

            ////if (model == null)
            ////{
            ////    return null;
            ////}
            ////else
            ////{
            ////    dbContext.Teller.Remove(model);
            ////    await dbContext.SaveChangesAsync();
            ////}
            return model;
        }

        public async Task<List<Teller_UserModel>> getUserListAsync()
        {
            return await dbContext.Teller_User.ToListAsync();
        }
    }

}
