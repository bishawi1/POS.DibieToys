using POS.DAL.Repositories;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Client
{
    public static class UsersRepository
    {
        public static ResultModel verifyLogin(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return new ResultModel
                {
                    ErrorText = "تحقق من اسم المستخدم وكلمة المرور!",
                    StatusCode = "failed"
                };
            }
            else
            {
                try
                {
                    SQLUsersRepository repos = new SQLUsersRepository();
                    UsersModel model = repos.login(userName, password);
                    if (model == null)
                    {
                        return new ResultModel
                        {
                            ErrorText = "تحقق من اسم المستخدم وكلمة المرور!",
                            StatusCode = "failed"
                        };
                   }
                    else
                    {
                        return new ResultModel
                        {
                            Data = model,
                            StatusCode = "success"
                        };
                    }
                }
                catch (Exception ex)
                {
                    return new ResultModel
                    {
                        ErrorText = ex.Message,
                        StatusCode = "failed"
                    };
                }
            }
        }

    }
}
