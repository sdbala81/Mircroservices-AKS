using AutoMapper;
using GlobalTickets.Services.ShoppingBasket.Entities;
using GlobalTickets.Services.ShoppingBasket.Models;

namespace GlobalTickets.Services.ShoppingBasket.Profiles
{
    public class BasketChangeEventProfile: Profile
    {
        public BasketChangeEventProfile()
        {
            CreateMap<BasketChangeEvent, BasketChangeEventForPublication>().ReverseMap();
        }
    }
}
