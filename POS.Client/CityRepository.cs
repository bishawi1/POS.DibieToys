using Azure;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using POS.DAL;
using POS.DAL.Repositories;
using POS.Shared.DTOs;
using POS.Shared.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace POS.Client
{
    public class CityRepository
    {
        public static async Task<ResultModel> getAllAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("Cities");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<List<CityModel>>(oResult.Data.ToString());
            }

            return oResult;

            //ResultModel result = await Client.CityRepository.getAllAsync();
            //SQLCityRepository repository = new SQLCityRepository(General.dataContext);
            //List<CityModel> citises=await repository.getAllAsync();
            //ResultModel oResult = new ResultModel()
            //{
            //    Data=citises,
            //    StatusCode = "success",
            //};

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://ala3lam-001-site1.htempurl.com/api/");
            ////client.BaseAddress = new Uri("https://localhost:7282/api/");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));
            //var response = await client.GetAsync("Cities");
            //var oResult = await response.Content.ReadAsAsync<ResultModel>();
            //// ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            //if (oResult.StatusCode == "200")
            //{
            //    oResult.Data = JsonConvert.DeserializeObject<List<CityModel>>(oResult.Data.ToString());
            //}

            return oResult;


        }
        public static async Task<ResultModel> getCity(byte cityId)
        {
            SQLCityRepository repository = new SQLCityRepository(General.dataContext);
            CityModel city = await repository.getByIdAsync(cityId);
            ResultModel oResult = new ResultModel()
            {
                Data = city,
                StatusCode = "success",
            };



            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://ala3lam-001-site1.htempurl.com/api/");
            ////client.BaseAddress = new Uri("https://localhost:7282/api/");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));
            //var response = await client.GetAsync($"Cities/{cityId}");
            //var oResult = await response.Content.ReadAsAsync<ResultModel>();
            //// ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            //if (oResult.StatusCode == "200")
            //{
            //    oResult.Data = JsonConvert.DeserializeObject<CityModel>(oResult.Data.ToString());
            //}

            return oResult;


        }

        public static async Task<ResultModel> addCity(CreateCityRequestDto request)
        {
            CityModel model = new() 
            {
                City_Name=request.City_Name,
                City_Notes=request.City_Notes,
                User_Name=request.User_Name,            
                Time_Stamp=DateTime.Now
            };
            SQLCityRepository repository = new SQLCityRepository(General.dataContext);
            CityModel city = await repository.createAsync(model);
            ResultModel oResult = new ResultModel()
            {
                Data = city,
                StatusCode = "success",
            };


            //ResultModel oResult = new ResultModel();
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(Constants.BaseUrl + "Cities");

            //var json = JsonConvert.SerializeObject(request);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            //var response = client.PostAsync(Constants.BaseUrl + "Cities", content).Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    var responseContent = response.Content.ReadAsStringAsync().Result;
            //    oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
            //    oResult.Data = JsonConvert.DeserializeObject<CityModel>(oResult.Data.ToString());
            //    return oResult;
            //}
            //else
            //{
            //return new ResultModel()
            //{
            //    Data = null,
            //    ErrorText = "Error",
            //    StatusCode = response.StatusCode.ToString()
            //};
            //}

            return (oResult);
        }
        public static async Task<ResultModel> editCity(UpdateCityRequestDto request, byte cityId)
        {
            SQLCityRepository repository = new SQLCityRepository(General.dataContext);
            CityModel city = await repository.getByIdAsync(cityId);
            city.City_Notes = request.City_Notes;
            city.City_Name = request.City_Name;
            await repository.updateAsync(cityId, city);
            ResultModel oResult = new ResultModel()
            {
                Data = city,
                StatusCode = "success",
            };

            return oResult;


            //ResultModel oResult = new ResultModel();
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(Constants.BaseUrl + "Cities");

            //var json = JsonConvert.SerializeObject(model);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            //var response = client.PutAsync(Constants.BaseUrl + $"Cities/{cityId}", content).Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    var responseContent = response.Content.ReadAsStringAsync().Result;
            //    oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
            //    oResult.Data = JsonConvert.DeserializeObject<CityModel>(oResult.Data.ToString());
            //    return oResult;
            //}
            //else
            //{
            //    return new ResultModel()
            //    {
            //        Data = null,
            //        ErrorText = "Error",
            //        StatusCode = response.StatusCode.ToString()
            //    };
            //}
        }


    }
}
