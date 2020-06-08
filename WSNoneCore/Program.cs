using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WSNoneCore
{
    class Program
    {
        static HttpClientHandler handler = new HttpClientHandler()
        {
            UseDefaultCredentials = true
        };

        static HttpClient client = new HttpClient(handler);
        //static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Author a = new Author();
            a.Age = 16;
            a.FirstName = "Kelly";
            a.LastName = "System";
            a.Country = "German";

            var uriL = await CreateProductAsync(a);
        }


        static async Task<Uri> CreateProductAsync(Author author)
        {


           

            //var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            //var response = await httpClient.PostAsync("http://www.sample.com/write", stringContent);


            var stringAuthor = new StringContent(JsonConvert.SerializeObject(author), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(
                "https://localhost:44388/api/authors", stringAuthor);
            response.EnsureSuccessStatusCode();
            var status = response.StatusCode;
            var returnContent =await response.Content.ReadAsStringAsync();

            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}
