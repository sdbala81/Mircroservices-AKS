using AutoMapper;

namespace GlobalTickets.Services.Marketing.Profiles
{
    public class BasketChangeEventProfile : Profile
    {
        public BasketChangeEventProfile()
        {
            CreateMap<Models.BasketChangeEvent, Entities.BasketChangeEvent>();
        }
    }
}
