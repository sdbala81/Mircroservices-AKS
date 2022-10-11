using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalTickets.Services.ShoppingBasket.Entities;

namespace GlobalTickets.Services.ShoppingBasket.Repositories
{
    public interface IBasketChangeEventRepository
    {
        Task AddBasketEvent(BasketChangeEvent basketChangeEvent);
        Task<List<BasketChangeEvent>> GetBasketChangeEvents(DateTime startDate, int max);
    }
}
