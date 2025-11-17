using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.WebApi.Contracts
{
    public interface IUsersRepository
    {
        public UsersModel createAsync(UsersModel model);
        public List<UsersModel> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public UsersModel getByIdAsync(int userID);
        public UsersModel? updateAsync(int userID, UsersModel model);
        public UsersModel? deleteAsync(int userID);
        public UsersModel login(string userName, string password);
        public bool changePassword(int userId, string newPassword, string confirmPassword);

    }

}
