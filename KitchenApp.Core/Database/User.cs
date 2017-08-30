using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace KitchenApp.Database
{
    public class User
    {
        public static async Task<string> UserLogin(HttpClient httpClient, string appId, string apiKey, string login, string password)
        {
            httpClient.BaseAddress = new Uri("https://api.backendless.com/");
            var obj = new UserJsonObject(login, password);
            var content = JsonConvert.SerializeObject(obj);

            var result = await httpClient.PostAsync(appId + "/" + apiKey + "/users/login", 
                new StringContent(
                content.ToString(),
                Encoding.UTF8,
                "application/json"));
            return await result.Content.ReadAsStringAsync();
        }

        [JsonObject]
        class UserJsonObject
        {
            [JsonProperty]
            string login;
            [JsonProperty]
            string password;

            public UserJsonObject(string login, string password)
            {
                this.login = login;
                this.password = password;
            }
        }

    }
}
