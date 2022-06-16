using GalaxyMedico.Services.DrugAPI.Models.Dto;
using GalaxyMedico.Services.DrugAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.DrugAPI.Controllers
{
    [Route("api/drugs")]
    public class DrugAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private IDrugRespository _drugRepository;

        public DrugAPIController(IDrugRespository drugRespository)
        {
            _drugRepository = drugRespository;
            this._response = new ResponseDto();
        }
        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<DrugDto> drugDtos = await _drugRepository.GetDrugs();
                _response.Result = drugDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> GetDrugById(int id)
        {
            try
            {
                DrugDto drugDtos = await _drugRepository.GetDrugById(id);
                _response.Result = drugDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        public async Task<object> Post([FromBody]DrugDto drugDto)
        {
            try
            {
                DrugDto model = await _drugRepository.CreateUpdateDrug(drugDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut]
        public async Task<object> Put([FromBody] DrugDto drugDto)
        {
            try
            {
                DrugDto model = await _drugRepository.CreateUpdateDrug(drugDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _drugRepository.DeleteDrug(id);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
