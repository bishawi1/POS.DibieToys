using Newtonsoft.Json;
using POS.Shared.DTOs;
using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace POS.Client
{
    public class ItemBrandRepository
    {
        public async Task<ResultModel> getAllAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("ItemBrand");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<List<Item_BrandModel>>(oResult.Data.ToString());
            }

            return oResult;


        }

        public static async Task<ResultModel> getItemBrand(int itemBrandId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://ala3lam-001-site1.htempurl.com/api/");
            //client.BaseAddress = new Uri("https://localhost:7282/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync($"ItemBrand/{itemBrandId}");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<Item_BrandModel>(oResult.Data.ToString());
            }

            return oResult;
        }

        public static ResultModel addItemBrand(AddItemBrandRequestDto model)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "ItemBrand");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "ItemBrand", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<Item_BrandModel>(oResult.Data.ToString());
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
        public static ResultModel editItemBrand(UpdateItemBrandRequestDto model, int itemBrandId)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "ItemBrand");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PutAsync(Constants.BaseUrl + $"ItemBrand/{itemBrandId}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<Item_BrandModel>(oResult.Data.ToString());
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

    }
}
