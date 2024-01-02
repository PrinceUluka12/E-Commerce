﻿using ECommerce.Services.ShoppingCartAPI.Models.Dto;
using ECommerce.Services.ShoppingCartAPI.Service.IService;
using Newtonsoft.Json;

namespace ECommerce.Services.ShoppingCartAPI.Service
{
    public class ProductService : IProductService
    {
        private IHttpClientFactory _httpClientFactory;
        public ProductService(IHttpClientFactory clientFactory)
        {
            _httpClientFactory = clientFactory;
        }
        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient("Product");
            var response = await client.GetAsync($"/api/ProductAPI");
            var apiContent = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
            if (resp.IsSuccess)
            {
                return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(Convert.ToString(resp.Result));
            }
            return new List<ProductDto>();
        }
    }
}