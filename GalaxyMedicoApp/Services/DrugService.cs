using GalaxyMedicoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GalaxyMedicoApp.Services
{
    public class DrugService : BaseService, IDrugService
    {
        private readonly IHttpClientFactory _clientFactory;

        public DrugService(IHttpClientFactory clientFactory):base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<T> CreateDrugAsync<T>(DrugDto drugDto)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType=StaticDetails.APIType.POST,
                Data=drugDto,
                Url=StaticDetails.DrugAPIBase+"/api/drugs",
                AccessToken=""
            });
        }

        public async Task<T> DeleteDrugAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = StaticDetails.APIType.DELETE,
                Url = StaticDetails.DrugAPIBase + "/api/drugs/"+id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllDrugsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = StaticDetails.APIType.GET,
                Url = StaticDetails.DrugAPIBase + "/api/drugs",
                AccessToken = ""
            });
        }

        public async Task<T> GetDrugByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = StaticDetails.APIType.GET,
                Url = StaticDetails.DrugAPIBase + "/api/drugs/"+id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateDrugAsync<T>(DrugDto drugDto)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = StaticDetails.APIType.PUT,
                Data = drugDto,
                Url = StaticDetails.DrugAPIBase + "/api/drugs",
                AccessToken = ""
            });
        }
    }
}
