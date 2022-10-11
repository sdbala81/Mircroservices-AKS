using AutoMapper;
using GlobalTickets.Services.ShoppingBasket.Messages;
using GlobalTickets.Services.ShoppingBasket.Models;

namespace GlobalTickets.Services.ShoppingBasket.Profiles
{
    public class BasketCheckoutProfile: Profile
    {
        public BasketCheckoutProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutMessage>().ReverseMap();
        }
    }
}
