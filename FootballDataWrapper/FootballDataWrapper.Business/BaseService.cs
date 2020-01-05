using AutoMapper;
using FootballDataWrapper.Business.Exceptions;
using FootballDataWrapper.Data;
using FootballDataWrapper.Data.Contexts;
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
        protected IMapper mapper;
        protected UnitOfWork unitOfWork;

        public BaseService(string _apiKey, FootballDataContext context)
        {
            apiKey = _apiKey;
            mapper = ObjectMapper.Mapper;
            unitOfWork = new UnitOfWork(context);
        }


        protected void CompleteTransaction() 
        {
            //try
            //{
                unitOfWork.Complete();
            //}
            //catch (Exception)
            //{

            //    throw new ConectivityException("Server Error");
            //}
            
        }

        protected async Task<T> GetAsync<T>(string url)
        {
            try
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
            catch (Exception)
            {

                throw new ConectivityException("Server Error");
            }

        }
    }
}
