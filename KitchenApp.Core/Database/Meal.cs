using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace KitchenApp.Database
{
    public class Meal : BaseItem, IDatabaseMethods<Meal>
    {
        string objectId;
        string semester;
        DateTime dateTime;

        public Meal(string appId, string apiKey, HttpClient httpClient) : base(appId, apiKey, httpClient)
        {
            baseAddress = new Uri("https://api.backendless.com/" + appId + "/" + apiKey + "/data/Meal/");
        }

        public async Task<Meal> GetById(string id)
        {
            httpClient.BaseAddress = baseAddress;
            HttpResponseMessage response = await httpClient.GetAsync(id);
            string result = await response.Content.ReadAsStringAsync();

            Meal retVal = JsonConvert.DeserializeObject<Meal>(result);
            return retVal;
        }

    }
}
