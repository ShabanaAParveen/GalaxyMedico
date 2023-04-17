using GalaxyMedicoApp.Models;
using GalaxyMedicoApp.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedicoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDrugService _drugService;
        private readonly ICartService _cartService;

        public HomeController(ILogger<HomeController> logger, IDrugService drugService, ICartService cartService)
        {
            _logger = logger;
            _drugService = drugService;
            _cartService = cartService;
        }


        public async Task<IActionResult> Index()
        {
            List<DrugDto> list = new List<DrugDto>();
            var response = await _drugService.GetAllDrugsAsync<ResponseDto>("");
            if(response!=null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<DrugDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

       
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Details(int drugId)
        {
            DrugDto model = new DrugDto();
            var response = await _drugService.GetDrugByIdAsync<ResponseDto>(drugId,"");
            if (response != null && response.IsSuccess)
            {
                model = JsonConvert.DeserializeObject<DrugDto>(Convert.ToString(response.Result));
            }
            return View(model);
        }

        [HttpPost]
        [Authorize] 
        public async Task<IActionResult> Details(DrugDto drugDto)
        {
            CartDto model = new()
            {
                CartHeader = new CartHeaderDto
                {
                    UserId = User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value
                }            
            };
            CartDetailsDto cartDetailsDto = new CartDetailsDto()
            {
                Count=drugDto.Count,
                DrugId=drugDto.DrugId
            };
            var resp = await _drugService.GetDrugByIdAsync<ResponseDto>(drugDto.DrugId, "");
            if (resp != null && resp.IsSuccess)
            {
                cartDetailsDto.Drug = JsonConvert.DeserializeObject<DrugDto>(Convert.ToString(resp.Result));
            }
            List<CartDetailsDto> cartDetailsDtos = new();
            cartDetailsDtos.Add(cartDetailsDto);
            model.CartDetails = cartDetailsDtos;

            var accessToken = await HttpContext.GetTokenAsync("access_token");
            var addToCartResp = await _cartService.AddToCartAsync<ResponseDto>(model, accessToken);
            if (addToCartResp != null && addToCartResp.IsSuccess)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(drugDto);
        }

        [Authorize]
        public async Task<IActionResult> Login()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
