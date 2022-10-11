using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalTickets.Services.ShoppingBasket.DbContexts;
using GlobalTickets.Services.ShoppingBasket.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalTickets.Services.ShoppingBasket.Repositories
{
    public class BasketChangeEventRepository: IBasketChangeEventRepository
    {
        private readonly ShoppingBasketDbContext shoppingBasketDbContext;

        public BasketChangeEventRepository(ShoppingBasketDbContext shoppingBasketDbContext)
        {
            this.shoppingBasketDbContext = shoppingBasketDbContext;
        }

        public async Task AddBasketEvent(BasketChangeEvent basketChangeEvent)
        {
            await shoppingBasketDbContext.BasketChangeEvents.AddAsync(basketChangeEvent);
            await shoppingBasketDbContext.SaveChangesAsync();
        }

        public async Task<List<BasketChangeEvent>> GetBasketChangeEvents(DateTime startDate, int max)
        {
            return await shoppingBasketDbContext.BasketChangeEvents.Where(b => b.InsertedAt > startDate)
                .OrderBy(b => b.InsertedAt).Take(max).ToListAsync();
        }
    }
}
