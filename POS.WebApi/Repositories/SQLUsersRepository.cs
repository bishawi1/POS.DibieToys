
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
    public class SQLUsersRepository : IUsersRepository
    {
        private readonly DataContext dbContext;
        public SQLUsersRepository()
        {
            //this.dbContext = new DataContext();
        }
        public UsersModel createAsync(UsersModel model)
        {
            int userID = dbContext.Users.Max(r => r.User_ID);
            model.User_ID = userID + 1;
            dbContext.Users.AddAsync(model);
            dbContext.SaveChangesAsync();
            return model;
        }
        public List<UsersModel> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Users.AsQueryable();
            if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    //qView = qView.Where(r => r. Book_Author_Desc.Contains(filterQuery));
                }
            }
            if (pageSize == 0)
            {
                return qView.ToList();
            }
            else
            {
                var skipResults = (pageNumber - 1) * pageSize;
                return qView.Skip(skipResults).Take(pageSize).ToList();
            }
        }
        public UsersModel getByIdAsync(int userID)
        {
            return dbContext.Users.FirstOrDefault(r => r.User_ID == userID);
        }
        public UsersModel? updateAsync(int userID, UsersModel model)
        {
            dbContext.Users.Update(model);
            dbContext.SaveChangesAsync();
            return model;
        }
        public UsersModel? deleteAsync(int userID)
        {
            var model = dbContext.Users.FirstOrDefault(r => r.User_ID == userID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Users.Remove(model);
                dbContext.SaveChangesAsync();
            }
            return model;
        }

        public UsersModel login(string userName, string password)
        {
            UsersModel userModel = null;
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                userModel = dbContext.Users.FirstOrDefault(r => r.User_Name == userName && r.Password == password);
                if (userModel == null)
                {
                    throw new Exception("Not Found");
                }
                else
                {
                    return userModel;
                }
            }
            else
            {
                throw new Exception("Invalid user");
            }
        }

        public bool changePassword(int userId, string newPassword, string confirmPassword)
        {
            UsersModel userModel = null;
            if (!string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(confirmPassword))
            {
                if (newPassword == confirmPassword)
                {
                    userModel = dbContext.Users.FirstOrDefault(r => r.User_ID == userId);
                    if (userModel == null)
                    {
                        throw new Exception("Not Found");
                    }
                    else
                    {
                        userModel.Password = newPassword;
                        dbContext.Users.Update(userModel);
                        dbContext.SaveChanges();
                        return true;
                    }
                }
                else
                {
                    throw new Exception("Invalid Password");
                }
            }
            else
            {
                throw new Exception("Invalid user");
            }

        }
    }

}
