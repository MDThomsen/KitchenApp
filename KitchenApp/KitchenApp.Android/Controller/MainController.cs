using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using KitchenApp.Database;
    

namespace KitchenApp.Droid.Controller
{
    public class MainController
    {
        private const string appId = "9A4509DD-EFFD-CF27-FFC9-F6451A55FD00";
        private const string apiKey = "745C651A-F136-BC87-FF59-9239981CD900";

        private static HttpClient httpClient;

        public MainController()
        {
            httpClient = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
        }
         
        public async Task UserLogin(string login, string password)
        {
            User.UserLogin(httpClient, appId, apiKey, login, password);
        }

        public async Task<Meal> getMealById(string id)
        {
            return await new Meal(appId, apiKey, httpClient).GetById(id);
        }

    }
}