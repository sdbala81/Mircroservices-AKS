﻿using System;
using System.Threading.Tasks;
using GlobalTickets.Services.ShoppingBasket.Entities;

namespace GlobalTickets.Services.ShoppingBasket.Services
{
    public interface IEventCatalogService
    {
        Task<Event> GetEvent(Guid id);
    }
}