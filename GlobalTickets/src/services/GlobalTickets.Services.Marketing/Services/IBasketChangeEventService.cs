using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GlobalTickets.Services.Marketing.Models;

namespace GlobalTickets.Services.Marketing.Services
{
    public interface IBasketChangeEventService
    {
        Task<List<BasketChangeEvent>> GetBasketChangeEvents(DateTime startDate, int max);
    }
}