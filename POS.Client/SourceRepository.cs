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
    public class SourceRepository
    {
        public static async Task<ResultModel> getAllAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("Sources");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<List<SourceModel>>(oResult.Data.ToString());
            }

            return oResult;


        }
        public static ResultModel getBookSources(BookSourceQueryCriteriaViewModel criteria)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Sources");

            var json = JsonConvert.SerializeObject(criteria);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Sources/BookSourceQuery", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<List<BookSourceQueryModel>>(oResult.Data.ToString());
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
        public static async Task<ResultModel> getSource(short sourceId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            //client.BaseAddress = new Uri("https://localhost:7282/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync($"Sources/{sourceId}");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<SourceModel>(oResult.Data.ToString());
            }

            return oResult;


        }
        public static ResultModel addSource(CreateSourceRequestDto model)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Sources");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Sources", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<SourceModel>(oResult.Data.ToString());
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
        public static ResultModel editBookSource(UpdateSourceRequestDto model, int sourceId)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Sources");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PutAsync(Constants.BaseUrl + $"Sources/{sourceId}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<SourceModel>(oResult.Data.ToString());
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
