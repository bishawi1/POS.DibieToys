using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLTeller_UserRepository : ITellerUserRepository
    {
        private readonly DataContext dbContext;
        public SQLTeller_UserRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Teller_UserModel> createAsync(Teller_UserModel model)
        {
            int tellerUserID = dbContext.Teller_User.Max(r => r.Teller_User_ID);
            model.Teller_User_ID = tellerUserID + 1;
            await dbContext.Teller_User.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<Teller_UserModel>> getAllAsync()
        {
            var qView = dbContext.Teller_User.AsQueryable();

                return await qView.ToListAsync();
        }
        public async Task<Teller_UserModel> getByIdAsync(int tellerUserID)
        {
            return await dbContext.Teller_User.FirstOrDefaultAsync(r => r.Teller_User_ID == tellerUserID);
        }
        public async Task<Teller_UserModel?> updateAsync( Teller_UserModel model)
        {
            dbContext.Teller_User.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<Teller_UserModel?> deleteAsync(int tellerUserID)
        {
            var model = await dbContext.Teller_User.FirstOrDefaultAsync(r => r.Teller_User_ID == tellerUserID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Teller_User.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }
    }

}
