using ECommerce.Services.ShoppingCartAPI.Models.Dto;

namespace ECommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
