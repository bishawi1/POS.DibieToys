using POS.Shared.Models;

namespace POS.WebApi.Contracts
{
    public interface ITellerUserRepository
    {
        public Task<Teller_UserModel> createAsync(Teller_UserModel model);
        public Task<List<Teller_UserModel>> getAllAsync();
        public Task<Teller_UserModel> getByIdAsync(int telletUserId);
        public Task<Teller_UserModel?> updateAsync(Teller_UserModel model);
        public Task<Teller_UserModel?> deleteAsync(int tellerUserId);
    }
}
