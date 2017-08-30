using System;
using System.Net.Http;

namespace KitchenApp.Database
{
    public class BaseItem
    {
        protected string appId;
        protected string apiKey;
    
        protected HttpClient httpClient;

        protected Uri baseAddress;

        public BaseItem(string appId, string apiKey, HttpClient httpClient)
        {
            this.appId = appId;
            this.apiKey = apiKey;
            this.httpClient = httpClient;
        }
    }
}
