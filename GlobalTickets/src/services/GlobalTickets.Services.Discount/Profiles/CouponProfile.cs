using AutoMapper;
using GlobalTickets.Services.Discount.Entities;
using GlobalTickets.Services.Discount.Models;

namespace GlobalTickets.Services.Discount.Profiles
{
    public class CouponProfile : Profile
    {
        public CouponProfile()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();
        }
    }
}
