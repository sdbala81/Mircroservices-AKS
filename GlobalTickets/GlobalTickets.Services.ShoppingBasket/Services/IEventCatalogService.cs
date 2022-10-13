using GlobalTickets.Services.ShoppingBasket.Entities;
using System;
using System.Threading.Tasks;

namespace GlobalTickets.Services.ShoppingBasket.Services
{
    public interface IEventCatalogService
    {
        Task<Event> GetEvent(Guid id);
    }
}