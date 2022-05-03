using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatuers.Models
{
    public class MyAsyncMethods
    {
        //без async await
        public static Task<long?> GetPagelength()
        {
            HttpClient client = new HttpClient();
            var httpTask = client.GetAsync("http://apress.com");
            return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) =>
            {
                return antecedent.Result.Content.Headers.ContentLength;
            });
        }

        // пример с использованием async await
        public async static Task<long?> GetPagelengthAsync()
        {
            HttpClient client = new HttpClient();
            var httpMessage= await client.GetAsync("http://apress.com");
            return httpMessage.Content.Headers.ContentLength;
           
        }
    }
}
