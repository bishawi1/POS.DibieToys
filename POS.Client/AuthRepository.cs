
using Newtonsoft.Json;
using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.Models.Auth;
using POS.Shared.ViewModels.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POS.Client
{
    public static class AuthRepository
    {
        public static ResultModel Create(string UserName, string Password)
        {
            try
            {
                RegisterModel criteria = new RegisterModel();
                criteria.UserName = UserName;
                criteria.Email = criteria.UserName + "@Example.com";
                criteria.Password = Password;
                Uri uri = new Uri(Constants.BaseUrl + "Authenticate/Register");
                string jsonSring = JsonConvert.SerializeObject(criteria);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                RegisterResponseViewModel oResult = JsonConvert.DeserializeObject<RegisterResponseViewModel>(response);
                if (oResult.Status == "Success")
                {
                    return new ResultModel()
                    {
                        StatusCode = "200",
                        Data = "true",
                        ErrorText = ""
                    };
                }
                //UserSession oResult;
                //oResult = JsonConvert.DeserializeObject<UserSession>(response);
                return new ResultModel()
                {
                    StatusCode = "200",
                    Data =oResult.Status,
                    ErrorText = oResult.Message
                }; ;

            }
            catch (Exception ex)
            {
                return new ResultModel()
                {
                    StatusCode = "500",
                    Data = "",
                    ErrorText = ex.Message.ToString()
                };
            }
        }
        public static ResultModel login(string UserName, string Password) //As ResultModel
        {
            try
            {
                //bool boolClosed = true;
                LoginModel criteria = new LoginModel();
                criteria.userName = UserName;
                criteria.Password = Password;
                Uri uri = new Uri(Constants.BaseUrl + "Authenticate/Login");
                string jsonSring = JsonConvert.SerializeObject(criteria);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(response);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<UserSession>(oResult.Data.ToString());
                }
                //UserSession oResult;
                //oResult = JsonConvert.DeserializeObject<UserSession>(response);
                return oResult;

            }
            catch (UnauthorizedAccessException ex)
            {
                ErrorException exception = new ErrorException()
                {
                    ErrorCode = 401,
                    ErrorDesc = "محاولة دخول غير ناجحة"
                };
                throw exception;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static ResultModel changePassword(string UserName, string currentPassword,  string newPassword)
        {
            try
            {
                ChangePasswordModel criteria = new ChangePasswordModel();
                criteria.Username = UserName;
                criteria.NewPassword = newPassword;
                criteria.CurrentPassword = currentPassword;
                criteria.ConfirmNewPassword = newPassword;
                Uri uri = new Uri(Constants.BaseUrl + "Authenticate/Change-Password");
                string jsonSring = JsonConvert.SerializeObject(criteria);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                RegisterResponseViewModel oResult = JsonConvert.DeserializeObject<RegisterResponseViewModel>(response);
                if (oResult.Status == "Success")
                {
                    return new ResultModel()
                    {
                        StatusCode = "200",
                        Data = "true",
                        ErrorText = ""
                    };
                }
                //UserSession oResult;
                //oResult = JsonConvert.DeserializeObject<UserSession>(response);
                return new ResultModel()
                {
                    StatusCode = "200",
                    Data = oResult.Status,
                    ErrorText = oResult.Message
                }; ;

            }
            catch (Exception ex)
            {
                return new ResultModel()
                {
                    StatusCode = "500",
                    Data = "",
                    ErrorText = ex.Message.ToString()
                };
            }
        }
    }
}
