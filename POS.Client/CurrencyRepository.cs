using Newtonsoft.Json;
using POS.DAL.Repositories;
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
    public class CurrencyRepository
    {
        public async Task<ResultModel> getAllAsync()
        {
            //SQLCurrencyRepository repository = new (General.dataContext);
            //List<CurrencyModel> currencies = await repository.getAllAsync("","","");
            //ResultModel oResult = new ResultModel()
            //{
            //    Data = currencies,
            //    StatusCode = "success",
            //};



            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("Currency");
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            //ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<List<CurrencyModel>>(oResult.Data.ToString());
            }

            return oResult;


        }

    }

}
