using POS.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace POS.Client
{
    public static class General
    {
        public static DataContext dataContext;

        public static string SendRequest(Uri uri, Byte[] jsonDataBytes, String contentType, string method, string AccessToken = "", string TokenType = "Bearer")
        {
            string response;
            WebRequest request;

            try
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
                };
                var client = new HttpClient(handler);

                request = WebRequest.Create(uri);
                request.ContentLength = jsonDataBytes.Length;
                request.ContentType = contentType;
                request.Method = method;
                request.Timeout = 55000;
                if (AccessToken != "")
                {
                    request.PreAuthenticate = true;
                    request.Headers.Add("Authorization", TokenType.Trim() + " " + AccessToken);
                }

                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(jsonDataBytes, 0, jsonDataBytes.Length);
                    requestStream.Close();



                    using (var responseStream = request.GetResponse().GetResponseStream())
                    {
                        using (var reader = new StreamReader(responseStream))
                        {
                            response = reader.ReadToEnd();
                        }
                    }
                }


                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
