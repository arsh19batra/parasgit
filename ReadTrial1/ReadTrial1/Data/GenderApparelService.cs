using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace ReadTrial1.Data
{
    public class GenderApparelService : IGenderApparelService
    {
        private readonly HttpClient _client;
        public GenderApparelService(HttpClient client)
        {
            _client = client;
        }
            
            
            
            //var apparel=  _client.GetFromJsonAsync<GenderApparel[]>("api/ReadValues/7");
            //var q= apparel.Result;
            //foreach (var item in q)
            //{
            //    Console.WriteLine(item.ProductId);
            //    Console.WriteLine(item.ProductName);
            //}
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GenderApparel));
            //MemoryStream msobj = new MemoryStream();
            //serializer.WriteObject(msobj, apparel);
            //msobj.Position = 0;
            //StreamReader sr = new StreamReader(msobj);
            //string a = sr.ReadToEnd();
            //sr.Close();
            //msobj.Close();
            //
            ////var a = _client.GetAsync("api/ReadValues/7");
            //DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(GenderApparel));
            //GenderApparel Obj = (GenderApparel)deserializer.ReadObject(msobj);




            //var result = await System.Text.Json.JsonSerializer.Deserialize<GenderApparel>(a);

            
            //var responseTask =  _client.GetAsync("api/ReadValues/api/1");
            //responseTask.Wait();
            //var res = responseTask.Result;
            //if(res.IsSuccessStatusCode)
            //{
            //    var readTask = res.Content.ReadAsAsync<GenderApparel[]>();
            //    Console.WriteLine("\n\n\n"+res.Content+"\n\n\n");
            //    readTask.Wait();
            //    var qwe=readTask.Result;
            //    foreach (var item in qwe)
            //    {
            //        Console.WriteLine(item.ProductId);
            //        Console.WriteLine(item.ProductName);
            //    }
            //}
            //else
            //{
            //    throw new Exception("CouldnotFind");
            //}

        public async Task<List<Product>> GetProductByGenderId() 
        {
            var q= await GetAsync("https://localhost:5001/api/ReadValues/api/1");
            return q;
        }
        
        private static void AddHeader(HttpClient httpClient, IDictionary<string, string> headers)
        {
            if (!(headers?.Count > 0))
            {
                return;
            }

            foreach (var header in headers)
            {
                httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
            }
        }
        private static HttpClient GetHttpClient() => new HttpClient(new HttpClientHandler());
        public async Task<List<Product>> GetAsync(string requestUri, IDictionary<string, string> headers = null)
        {
            using var httpClient = GetHttpClient();

            AddHeader(httpClient, headers);
            var qwe = await httpClient.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<List<Product>>(qwe);
        }

    }
}
