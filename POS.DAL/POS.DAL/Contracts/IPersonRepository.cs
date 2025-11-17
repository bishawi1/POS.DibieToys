using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Contracts
{
    public interface IPersonRepository
    {
        public Task<PersonModel> createAsync(PersonModel model);

        public Task<List<PersonModel>> GetAllAsync();
        public Task<PersonModel> GetByIdAsync(Int16 PersonId);

        public Task<PersonModel?> updateAsync(Int16 PersonId, PersonModel model);
        public Task<PersonModel?> deleteAsync(Int16 PersonId);

        public Task<List<vPersonModel>?> getPersonQuery(PersonQueryCriteriaViewModel criteria,
                                                            string? sortBy, bool? isAscending = true,
                                                            int pageNumber = 1, int pageSize = 200);


    }
}
