using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FootballDataWrapper.Business
{
    public class BaseService
    {
        private string apiKey;

        public BaseService(string _apiKey)
        {
            apiKey = _apiKey;
        }

        protected async Task<T> GetAsync<T>(string url)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-Auth-Token", apiKey);
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(apiResponse);
                }
            }
        }
    }
}
