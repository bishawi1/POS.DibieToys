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

namespace POS.Client
{
    public class ItemRepository
    {
        public static async Task<ResultModel> update(UpdateItemRequestModel request)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Item");

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PutAsync(Constants.BaseUrl + "Item/"+ request.Item_ID.ToString(), content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<ItemModel>(oResult.Data.ToString());
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
        }
        public static async Task<ResultModel> add(AddItemRequestModel request)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Item");

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Item", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<ItemModel>(oResult.Data.ToString());
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
        }
        public static async Task<ResultModel> delete(int itemID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.DeleteAsync("Item/" + itemID.ToString());
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            // ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(data);
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<ItemModel>(oResult.Data.ToString());
            }

            return oResult;


        }



        public static async Task<ResultModel> addBeginQnt(AddItemUnitBeginQntRequestDto request)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Item/AddBeginQnt");

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Item/AddBeginQnt", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<Item_Unit_Begin_Qnt_Model>(oResult.Data.ToString());
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
        }

        public static async Task<ResultModel> uploadItemFile(int itemID, string fileName)
        {
            using var client = new HttpClient();
            using var form = new MultipartFormDataContent();

            var filePath = fileName;
            var fileStream = File.OpenRead(filePath);
            var fileContent = new StreamContent(fileStream);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("multipart/form-data");

            form.Add(fileContent, "file", Path.GetFileName(filePath));

            var response = await client.PostAsync($"{Constants.BaseUrl}Item/upload/{itemID}", form);
            var oResult = await response.Content.ReadFromJsonAsync<ResultModel>();
            if (oResult.StatusCode == "200")
            {
                oResult.Data = JsonConvert.DeserializeObject<ItemModel>(oResult.Data.ToString());
            }

            return oResult;
        }

        public static async Task<string> generateBarcode()
        {
            bool Cont = true;
            string barcode = string.Empty;
            while (Cont)
            {
                ItemQueryRepository repository = new ItemQueryRepository();
                ResultModel result = await repository.GenerateBarcode();
                if (result.StatusCode == "200")
                {
                    barcode = result.Data.ToString();
                    //mboolBarcodeGenerated = true;
                    if (Convert.ToInt32(barcode) > 23000)
                    {
                        Cont = false;
                    }
                }
            }
            return barcode;
        }
        public class ItemUnitStockDetailsForm
        {
        }
    }
}

