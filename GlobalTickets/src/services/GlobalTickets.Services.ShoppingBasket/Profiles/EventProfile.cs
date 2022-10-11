using AutoMapper;

namespace GlobalTickets.Services.ShoppingBasket.Profiles
{
    public class EventProfile: Profile
    {
        public EventProfile()
        {
            CreateMap<Entities.Event, Models.Event>().ReverseMap();
        }
    }
}
