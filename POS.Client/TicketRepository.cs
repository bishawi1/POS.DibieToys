using Newtonsoft.Json;
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
    public class TicketRepository
    {
        public static async Task<ResultModel> getAllAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("Ticket");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<List<TicketModel>>(oResult.Data.ToString());
            }

            return oResult;
        }
        public static ResultModel addTicket(CreateTicketRequestDto model)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Ticket");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Ticket", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<List<TicketModel>>(oResult.Data.ToString());
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

        public static async Task<ResultModel> getAllAsync(TicketListCriteriaViewModel criteria) //As ResultModel
        {
            try
            {
                //bool boolClosed = true;
                Uri uri = new Uri(Constants.BaseUrl + "Ticket/ListTicket");
                string jsonSring = JsonConvert.SerializeObject(criteria);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(response);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<List<TicketModel>>(oResult.Data.ToString());
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

        public static ResultModel addReserveToysRoom(AddReserveToysRookRequestDto model)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Ticket/ReserveToysRoom");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Ticket/ReserveToysRoom", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<Reserve_Toy_RoomModel>(oResult.Data.ToString());
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
        public static async Task<ResultModel> GetReserveToysRoomList(ReserveToysRoomCriteriaViewModel criteria) //As ResultModel
        {
            try
            {
                //bool boolClosed = true;
                Uri uri = new Uri(Constants.BaseUrl + "Ticket/GetReserveToysRoomList");
                string jsonSring = JsonConvert.SerializeObject(criteria);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(response);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<List<Reserve_Toy_RoomModel>>(oResult.Data.ToString());
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
        public static async Task<ResultModel> editReserveToysRoom(EditReserveToysRookRequestDto model) //As ResultModel
        {
            try
            {
                //bool boolClosed = true;
                Uri uri = new Uri(Constants.BaseUrl + "Ticket/EditReserveToysRoom");
                string jsonSring = JsonConvert.SerializeObject(model);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(response);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<Reserve_Toy_RoomModel>(oResult.Data.ToString());
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
        public static async Task<ResultModel> cancelReserveToysRoom(int reserveToyRoomId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Ticket/CancelReserveToysRoom");
            //client.BaseAddress = new Uri("https://localhost:7282/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(Constants.BaseUrl + $"Ticket/CancelReserveToysRoom/{reserveToyRoomId}");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<Reserve_Toy_RoomModel>(oResult.Data.ToString());
            }

            return oResult;
        }
        public static async Task<ResultModel> DoReserveToysRoom(int reserveToyRoomId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Ticket/DoReserveToysRoom");
            //client.BaseAddress = new Uri("https://localhost:7282/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(Constants.BaseUrl + $"Ticket/DoReserveToysRoom/{reserveToyRoomId}");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<Reserve_Toy_RoomModel>(oResult.Data.ToString());
            }

            return oResult;
        }

    }
}
