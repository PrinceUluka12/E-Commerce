using ECommerce.Services.ShoppingCartAPI.Models.Dto;

namespace ECommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
