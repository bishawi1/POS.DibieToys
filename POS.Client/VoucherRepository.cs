using Newtonsoft.Json;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Client
{
    public class VoucherRepository
    {
        public static ResultModel getVoucherQuery(VoucherQueryCriteriaViewModel criteria) //As ResultModel
        {
            try
            {
                //bool boolClosed = true;
                Uri uri = new Uri(Constants.BaseUrl + "Voucher/Query");
                string jsonSring = JsonConvert.SerializeObject(criteria);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(response);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<List<vVoucherModel>>(oResult.Data.ToString());
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

        public static ResultModel getPurchaseInvoiceQuery(PurchaseInvoiceQueryCriteriaViewModel criteria) //As ResultModel
        {
            try
            {
                //bool boolClosed = true;
                Uri uri = new Uri(Constants.BaseUrl + "Voucher/PurchaseInvoiceQuery");
                string jsonSring = JsonConvert.SerializeObject(criteria);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(response);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<List<vPurchase_Invoice_Model>>(oResult.Data.ToString());
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

        public static ResultModel getVoucherTotal(VoucherQueryCriteriaViewModel criteria) //As ResultModel
        {
            try
            {
                //bool boolClosed = true;
                Uri uri = new Uri(Constants.BaseUrl + "Voucher/VoucherTotals");
                string jsonSring = JsonConvert.SerializeObject(criteria);
                var data = Encoding.UTF8.GetBytes(jsonSring);
                var response = General.SendRequest(uri, data, "application/json", "POST");
                ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(response);
                if (oResult.StatusCode == "200")
                {
                    oResult.Data = JsonConvert.DeserializeObject<List<VoucherTotalViewModel>>(oResult.Data.ToString());
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

        public static ResultModel addVoucher(CreateVoucherRequestDto model)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Voucher");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(Constants.BaseUrl + "Voucher", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<VoucherModel>(oResult.Data.ToString());
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
        public static ResultModel editVoucher(UpdateVoucherRequestDto model, int voucherId)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Voucher");

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PutAsync(Constants.BaseUrl + $"Voucher/{voucherId}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<VoucherModel>(oResult.Data.ToString());
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

        public static ResultModel changeVoucherType(int voucherId, byte voucherTypeId)
        {
            ResultModel oResult = new ResultModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BaseUrl + "Voucher");

            var json = "";// JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PutAsync(Constants.BaseUrl + $"Voucher/{voucherId}/{voucherTypeId}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<ResultModel>(responseContent);
                oResult.Data = JsonConvert.DeserializeObject<VoucherModel>(oResult.Data.ToString());
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

        //public static ResultModel getStatement(StatementOfAccountCriteriaViewModel criteria) //As ResultModel
        //{
        //    try
        //    {
        //        //bool boolClosed = true;
        //        Uri uri = new Uri(Constants.BaseUrl + "Vouchers/Satetment");
        //        string jsonSring = JsonConvert.SerializeObject(criteria);
        //        var data = Encoding.UTF8.GetBytes(jsonSring);
        //        var response = General.SendRequest(uri, data, "application/json", "POST");
        //        ResultModel oResult = JsonConvert.DeserializeObject<ResultModel>(response);
        //        if (oResult.StatusCode == "200")
        //        {
        //            oResult.Data = JsonConvert.DeserializeObject<List<StatementOfAccountModel>>(oResult.Data.ToString());
        //        }
        //        //UserSession oResult;
        //        //oResult = JsonConvert.DeserializeObject<UserSession>(response);
        //        return oResult;

        //    }
        //    catch (UnauthorizedAccessException ex)
        //    {
        //        ErrorException exception = new ErrorException()
        //        {
        //            ErrorCode = 401,
        //            ErrorDesc = "غير مصرح لك الوصول الى البيانات"
        //        };
        //        throw exception;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

    }

}
