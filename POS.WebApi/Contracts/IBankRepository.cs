using POS.Shared.Models;

namespace POS.WebApi.Contracts
{
    public interface IBankRepository
    {
        public Task<BankModel> createAsync(BankModel model);
        public Task<List<BankModel>> getAllAsync();
        public Task<BankModel> getByIdAsync(byte bankNo);
        public Task<BankModel?> updateAsync(byte bankNo, BankModel model);
        public Task<BankModel?> deleteAsync(byte bankNo);
    }

}
