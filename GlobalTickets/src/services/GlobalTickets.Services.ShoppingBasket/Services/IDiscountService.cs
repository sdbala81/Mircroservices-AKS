using System;
using System.Threading.Tasks;
using GlobalTickets.Services.ShoppingBasket.Models;

namespace GlobalTickets.Services.ShoppingBasket.Services
{
    public interface IDiscountService
    {
        Task<Coupon> GetCoupon(Guid couponId);
        Task<Coupon> GetCouponWithError(Guid couponId);
    }
}
