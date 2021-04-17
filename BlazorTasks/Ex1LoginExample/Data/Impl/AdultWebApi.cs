using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Ex1LoginExample.Models;

namespace Ex1LoginExample.Data.Impl
{
    public class AdultWebApi : IAdultsData
    {
        private string path = "https://localhost:5001/Adults";
        private HttpClient client;
        public AdultWebApi(HttpClient client)
        {
            this.client = client;
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
         
            HttpResponseMessage status = await client.GetAsync(path);
            if (!status.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {status.StatusCode},{status.ReasonPhrase}");
            }

            string result = await status.Content.ReadAsStringAsync();
            List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>( result, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            return adults;
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
          
            string adultAsJson = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json"
            );
          
            HttpResponseMessage status= await client.PostAsync(path, content);
            if (!status.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {status.StatusCode}, {status.ReasonPhrase}");
            }

            return adult;
        }

        public async Task RemoveAdultAsync(int adultID)
        {
            HttpResponseMessage status = await client.DeleteAsync($"{path}/{adultID}");
            if (!status.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {status.StatusCode}, {status.ReasonPhrase}");
            }
        }

        public async Task<Adult> UpdateAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage status = await client.PatchAsync($"{path}/{adult.Id}", content);
            if (!status.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {status.StatusCode}, {status.ReasonPhrase}");
            }

            return adult;
        }

        public async Task<Adult> Get(int id)
        {

            HttpResponseMessage status = await client.GetAsync($"{path}/{id}");

            if (!status.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {status.StatusCode}, {status.ReasonPhrase}");
            }


            string result = await status.Content.ReadAsStringAsync();
            Adult adult = JsonSerializer.Deserialize<Adult>( result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return adult;
        }
        
    }
}