﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using GlobalTickets.Services.ShoppingBasket.DbContexts;
using GlobalTickets.Services.ShoppingBasket.Entities;

namespace GlobalTickets.Services.ShoppingBasket.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ShoppingBasketDbContext shoppingBasketDbContext;

        public EventRepository(ShoppingBasketDbContext shoppingBasketDbContext)
        {
            this.shoppingBasketDbContext = shoppingBasketDbContext;
        }

        public async Task<bool> EventExists(Guid eventId)
        {
            return await shoppingBasketDbContext.Events.AnyAsync(e => e.EventId == eventId);
        }

        public void AddEvent(Event theEvent)
        {
            shoppingBasketDbContext.Events.Add(theEvent);

        }

        public async Task<bool> SaveChanges()
        {
            return (await shoppingBasketDbContext.SaveChangesAsync() > 0);
        }
    }
}
