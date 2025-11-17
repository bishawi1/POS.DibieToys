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
    public class TellerRepository
    {
        public static async Task<ResultModel> getLoginTeller(string userName)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Constants.BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync($"Teller/GetByUser/{userName}");
                var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
                // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<Teller_UserModel>(oResult.Data.ToString());
                }
                return oResult;

            }
            catch (Exception ex)
            {

                throw;
            }



        }
        public static async Task<ResultModel> getTellerList()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Constants.BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync($"Teller/GetUserList");
                var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
                // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<List<Teller_UserModel>>(oResult.Data.ToString());
                }
                return oResult;

            }
            catch (Exception ex)
            {

                throw;
            }



        }

    }
}
