using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.WebApi.Contracts
{
    public interface IPersonRepository
    {
        public Task<PersonModel> createAsync(PersonModel model);
        public Task<List<PersonModel>> getAllAsync();
        public Task<PersonModel> getByIdAsync(short personID);
        public Task<PersonModel?> updateAsync(short personID, PersonModel model);
        public Task<PersonModel?> deleteAsync(short personID);
        public Task<List<vPersonModel>?> getPersonQuery(PersonQueryCriteriaViewModel criteria);
        public Task<List<vPersonStatementOfAccountModel>?> getStatementOfAccount(PersonStatementOfAccountCriteriaViewModel criteria);


    }
}
