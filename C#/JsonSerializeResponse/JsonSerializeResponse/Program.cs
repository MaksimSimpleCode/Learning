using HelloLinux.Models.Weather;
using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonSerializeResponse
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start!");
            string response = await Request("53", "50", "ru_RU");
            //var options = new JsonSerializerOptions()
            //{
            //    NumberHandling = JsonNumberHandling.AllowReadingFromString |JsonNumberHandling.WriteAsString
            //};
            WeatherResponse myDeserializedClass = JsonSerializer.Deserialize<WeatherResponse>(response);
            Console.WriteLine("Done!");
            Console.WriteLine(myDeserializedClass.now.ToString());

        }
        private static async Task<string> Request(string lat, string lon, string lang, bool isRepeatOnNonAuth = true)
        {

            var req = (HttpWebRequest)WebRequest.Create(new Uri(String.Format($"https://api.weather.yandex.ru/v2/forecast/?{lat}&{lon}")));
            req.Method = "GET";
            req.ContentType = "application/json";
            req.Accept = "application/json";
            req.Credentials = System.Net.CredentialCache.DefaultCredentials;
            req.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            req.Timeout = 1000;


            req.Headers.Add("X-Yandex-API-Key", "key.....");


            try
            {
                using var response = await req.GetResponseAsync();
                using var responseStream = response.GetResponseStream();
                using var streamReader = new StreamReader(responseStream);
                var result = new { IsSuccess = true, ResponseStr = await streamReader.ReadToEndAsync() };
                return result.ResponseStr;
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.Timeout)
                {
                    var result = new { IsSuccess = false, ResponseStr = e.Message, IsTimeout = true };
                }
                if (e.Response == null)
                {
                    var result = new { IsSuccess = false, ResponseStr = e.Message + " null response" };
                }
                else if (((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.Unauthorized && isRepeatOnNonAuth)
                {
                    //Authorize();
                    //return await Request(serviceUri, body, method, false);
                }
                using (var streamReader = new StreamReader(e.Response.GetResponseStream()))
                {
                    var res = await streamReader.ReadToEndAsync();
                    var result = new { IsSuccess = false, ResponseStr = e.Message + " " + res };
                    return result.ResponseStr;
                }
            }
        }
    }

}
