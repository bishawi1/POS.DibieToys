using Azure.Core;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using POS.DAL.Repositories;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace POS.Client
{
    public class CustomerRepository
    {
        public async Task<ResultModel> getAllAsync(string personName)
        {
            //SQLPersonRepository repository = new SQLPersonRepository(General.dataContext);
            //List<PersonModel> persons = await repository.GetAllAsync();
            //return new ResultModel()
            //{
            //    Data = persons,
            //    StatusCode="success"
            //};
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("Person");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            //ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<List<PersonModel>>(oResult.Data.ToString());
            }
            return oResult;
        }
        public static async Task<ResultModel> getCustomerQuery(PersonQueryCriteriaViewModel criteria) //As ResultModel
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "/Person/Query");

            var json = JsonConvert.SerializeObject(criteria);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Person/Query", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<List<vPersonModel>>(oResult.Data.ToString());
                return oResult;
            }
            else
            {
                return new ResultModel()
                {
                    Data = null,
                    ErrorText = "Error",
                    StatusCode = response.StatusCode.ToString()
                };
            }

            return (oResult);

            //try
            //{
            //    SQLPersonRepository repository = new SQLPersonRepository(General.dataContext);
            //    List<vPersonModel> persons= await repository.getPersonQuery(criteria,"");
            //    return new ResultModel()
            //    {
            //        Data=persons,
            //        StatusCode="success"
            //    };
            //}
            //catch (Exception ex)
            //{
            //    return new ResultModel()
            //    {
            //        ErrorText = ex.Message,
            //        StatusCode = "failed"
            //    };
            //}
        }
        public static ResultModel editCustomer(UpdatePersonRequestDto model, int customerId)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Person");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PutAsync(Constants.BaseUrl + $"Person/{customerId}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<PersonModel>(oResult.Data.ToString());
                return oResult;
            }
            else
            {
                return new ResultModel()
                {
                    Data = null,
                    ErrorText = "Error",
                    StatusCode = response.StatusCode.ToString()
                };
            }
        }
        public static async Task<ResultModel> addCustomer(CreatePersonRequestDto request)
        {
            //SQLPersonRepository repository = new SQLPersonRepository(General.dataContext);
            //PersonModel model = new()
            //{
            //    Address=request.Address,
            //    Mobile=request.Mobile,
            //    Begining_Balance_Amount=request.Begining_Balance_Amount,
            //    City_ID=request.City_ID,
            //    Commercial_Name=request.Commercial_Name,
            //    Person_Account_ID=request.Person_Account_ID,
            //    Person_Name=request.Person_Name,
            //    Person_Notes=request.Person_Notes,
            //    Sell_Discount_Percent=request.Sell_Discount_Percent,
            //    User_Name=request.User_Name,
                
            //}; 
            //model= await repository.createAsync(model);
            //return new ResultModel()
            //{
            //    Data=model,
            //    StatusCode="success"
            //};




            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Person");

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Person", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<PersonModel>(oResult.Data.ToString());
                return oResult;
            }
            else
            {
                return new ResultModel()
                {
                    Data = null,
                    ErrorText = "Error",
                    StatusCode = response.StatusCode.ToString()
                };
            }
        }
        public static ResultModel getFinanceStatement(PersonStatementOfAccountCriteriaViewModel criteria) //As ResultModel
        {
            try
            {
                //bool boolClosed = true;
                Uri uri = new Uri(Constants.BaseUrl + "Person/FinanceStatement");
                string jsonSring = JsonConvert.SerializeObject(criteria);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(response);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<List<vPersonStatementOfAccountModel>>(oResult.Data.ToString());
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
                    ErrorDesc = "غير مصرح لك الوصول الى البيانات"
                };
                throw exception;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
