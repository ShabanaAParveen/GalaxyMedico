using GalaxyMedicoApp.Models;
using GalaxyMedicoApp.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedicoApp.Controllers
{
    public class DrugController : Controller
    {
        public readonly IDrugService _drugService;

        public DrugController(IDrugService drugService)
        {
            _drugService = drugService;
        }
        public async Task<IActionResult> DrugIndex()
        {
            List<DrugDto> list = new();
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            var response = await _drugService.GetAllDrugsAsync<ResponseDto>(accessToken);
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<DrugDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

        public async Task<IActionResult> CreateDrug()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDrug(DrugDto model)
        {
            if (ModelState.IsValid)
            {
                var accessToken = await HttpContext.GetTokenAsync("access_token");

                var response = await _drugService.CreateDrugAsync<ResponseDto>(model, accessToken);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(DrugIndex));
                }
            }
            return View(model);
        }

        public async Task<IActionResult> EditDrug(int drugId)
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            var response = await _drugService.GetDrugByIdAsync<ResponseDto>(drugId, accessToken);
            if (response != null && response.IsSuccess)
            {
                DrugDto model = JsonConvert.DeserializeObject<DrugDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditDrug(DrugDto model)
        {
            if (ModelState.IsValid)
            {
                var accessToken = await HttpContext.GetTokenAsync("access_token");
                var response = await _drugService.UpdateDrugAsync<ResponseDto>(model, accessToken);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(DrugIndex));
                }
            }
            return View(model);
        }

       [Authorize(Roles ="Admin")]
        public async Task<IActionResult> DeleteDrug(int drugId)
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            var response = await _drugService.GetDrugByIdAsync<ResponseDto>(drugId,accessToken);
            if (response != null && response.IsSuccess)
            {
                DrugDto model = JsonConvert.DeserializeObject<DrugDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
       [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDrug(DrugDto model)
        {
            if (ModelState.IsValid)
            {
                var accessToken = await HttpContext.GetTokenAsync("access_token");
                var response = await _drugService.DeleteDrugAsync<ResponseDto>(model.DrugId,accessToken);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(DrugIndex));
                }
            }
            return View(model);
        }
    }
}
