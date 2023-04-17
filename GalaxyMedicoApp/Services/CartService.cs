using GalaxyMedicoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GalaxyMedicoApp.Services
{
    public class CartService : BaseService,ICartService
    {
        private readonly IHttpClientFactory _clientFactory;
        public CartService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> Checkout<T>(CartHeaderDto cartHeader, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticDetails.APIType.POST,
                Data = cartHeader,
                Url = StaticDetails.ShoppingCartAPIBase + "/api/cart/checkout",
                AccessToken = token
            });
        }


        public async Task<T> AddToCartAsync<T>(CartDto cartDto, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = StaticDetails.APIType.POST,
                Data = cartDto,
                Url = StaticDetails.ShoppingCartAPIBase + "/api/cart/AddCart",
                AccessToken = token
            });
        }

        public async Task<T> GetCartByUserIdAsync<T>(string userId, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = StaticDetails.APIType.GET,
                Url = StaticDetails.ShoppingCartAPIBase + "/api/cart/GetCart/" + userId,
                AccessToken = token
            });
        }

        public async Task<T> RemoveFromCartAsync<T>(int cartDetailsId, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = StaticDetails.APIType.DELETE,
                Url = StaticDetails.ShoppingCartAPIBase + "/api/cart/RemoveFromCart/" + cartDetailsId,
                AccessToken = token
            });
        }

        public async Task<T> UpdateCartAsync<T>(CartDto cartDto, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = StaticDetails.APIType.PUT,
                Data = cartDto,
                Url = StaticDetails.DrugAPIBase + "/api/cart/UpdateCart",
                AccessToken = token
            });
        }

        public async Task<T> ApplyCoupon<T>(CartDto cartDto, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticDetails.APIType.POST,
                Data = cartDto,
                Url = StaticDetails.ShoppingCartAPIBase + "/api/cart/ApplyCoupon",
                AccessToken = token
            });
        }

        public async Task<T> RemoveCoupon<T>(string userId, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticDetails.APIType.POST,
                Data = userId,
                Url = StaticDetails.ShoppingCartAPIBase + "/api/cart/RemoveCoupon",
                AccessToken = token
            });
        }
    }
}
