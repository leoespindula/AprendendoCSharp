using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AprendendoCSharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            var testeApi = await client.GetAsync("https://jsonplaceholder.typicode.com/comments");
            var consumoApi = await testeApi.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<ApiFake[] > (consumoApi);

            foreach (var item in users)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
