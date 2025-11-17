using Newtonsoft.Json;
using POS.Shared.DTOs;
using POS.Shared.DTOs.Books;
using POS.Shared.Models;
using POS.Shared.Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace POS.Client
{
    public class BookSubjectRepository
    {
        public static async Task<ResultModel> getAllAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("Book_Subject");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<List<Book_SubjectModel>>(oResult.Data.ToString());
            }

            return oResult;


        }
        public static async Task<ResultModel> getBookSubject(int bookSubjectId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync($"Book_Subject/{bookSubjectId}");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<Book_SubjectModel>(oResult.Data.ToString());
            }

            return oResult;


        }
        public static ResultModel addBookSubject(CreateBook_SubjectRequestDto model)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Book_Subject");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Book_Subject", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<Book_SubjectModel>(oResult.Data.ToString());
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
        public static ResultModel editBookAuthor(UpdateBook_SubjectRequestDto model, int bookSubjectId)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Book_Subject");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PutAsync(Constants.BaseUrl + $"Book_Subject/{bookSubjectId}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<Book_SubjectModel>(oResult.Data.ToString());
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
