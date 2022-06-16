using GalaxyMedicoApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyMedicoApp.Services
{
    public class BaseService : IBaseService,IDisposable
    {
        public ResponseDto responseModel { get; set; }
        public IHttpClientFactory _httpClient { get; set; }
        public string DisplayMessage { get; private set; }

        private bool isDisposed;
        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new ResponseDto();
            this._httpClient = httpClient;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if (disposing)
            {
                // free managed resources
                _httpClient = null;
               
            }
            // free unmanged if any
            isDisposed = true;

        }

        public async Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            try
            {
                var client = _httpClient.CreateClient("DrugAPI");
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Headers.Add("Accept", "application/json");
                httpRequestMessage.RequestUri = new Uri(apiRequest.Url);
                client.DefaultRequestHeaders.Clear();
                if(apiRequest.Data!=null)
                {
                    httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),Encoding.UTF8,"application/json");
                }
                HttpResponseMessage httpResponseMessage = null;
                switch (apiRequest.ApiType)
                {
                    default:
                        httpRequestMessage.Method = HttpMethod.Get;
                        break;
                    case StaticDetails.APIType.POST:
                        httpRequestMessage.Method = HttpMethod.Post;
                        break;
                    case StaticDetails.APIType.PUT:
                        httpRequestMessage.Method = HttpMethod.Put;
                        break;
                    case StaticDetails.APIType.DELETE:
                        httpRequestMessage.Method = HttpMethod.Delete;
                        break;
                
                }

                httpResponseMessage = await client.SendAsync(httpRequestMessage);
                var apiContent =await httpResponseMessage.Content.ReadAsStringAsync();
                var apiResponseDto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseDto;
            }
            catch (Exception e)
            {
                var dto = new ResponseDto
                {
                    DisplayMessage = "Error",
                    ErrorMessages = new List<string> { Convert.ToString(e.Message) },
                    IsSuccess = false
                };
                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDto = JsonConvert.DeserializeObject<T>(res);
                return apiResponseDto;
            }
        }
    }
}
