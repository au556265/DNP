using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BlazorAssignment.Models;
using Microsoft.AspNetCore.SignalR;

namespace BlazorAssignment.Data.Impl
{
    public class UserWebApi : IUserService
    {
        private string path = "https://localhost:5001/Users";
        private HttpClient client;

        public UserWebApi(HttpClient client)
        {
            this.client = client;
        }

        public async Task<User> ValidateUser(string username, string password)
        { 
           
          HttpResponseMessage status = await client.GetAsync($"{path}?username={username}&password={password}");
          if (status.IsSuccessStatusCode)
          {
              string userAsJson = await status.Content.ReadAsStringAsync();
              User resultUser = JsonSerializer.Deserialize<User>(userAsJson,new JsonSerializerOptions
              {
                  PropertyNamingPolicy = JsonNamingPolicy.CamelCase
              });
              return resultUser;
          }
          
          throw new Exception($"{await status.Content.ReadAsStringAsync()}");
          
        }

        public async Task RegisterUser(User user)
        {
           
          string userAsJson = JsonSerializer.Serialize(user);
          StringContent content = new StringContent(
              userAsJson,
              Encoding.UTF8,
              "application/json"
          );
          
          var status= await client.PostAsync(path, content);
           if (!status.IsSuccessStatusCode)
           {
               var msg = await status.Content.ReadAsStringAsync();
               
               throw new ArgumentException($"{msg}" );
           }
           
        }
    }
}