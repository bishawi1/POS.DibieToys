using POS.Shared.DTOs;
using POS.Shared.Models;

namespace POS.WebApi.Contracts
{
    public interface ITellerRepository
    {
        public Task<TellerModel> createAsync(TellerModel model);
        public Task<List<TellerModel>> getAllAsync();
        public Task<TellerModel> getByIdAsync(int tellerId);
        public Task<Teller_UserModel> getByUserAsync(string tellerUserName);
        public Task<List<Teller_UserModel>> getUserListAsync();

        public Task<TellerModel?> updateAsync(TellerModel model);
        public Task<TellerModel?> deleteAsync(int tellerId);

    }
}
