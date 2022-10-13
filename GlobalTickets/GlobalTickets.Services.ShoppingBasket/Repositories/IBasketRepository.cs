﻿using GlobalTickets.Services.ShoppingBasket.Entities;
using System;
using System.Threading.Tasks;

namespace GlobalTickets.Services.ShoppingBasket.Repositories
{
    public interface IBasketRepository
    {
        Task<bool> BasketExists(Guid basketId);

        Task<Basket> GetBasketById(Guid basketId);

        void AddBasket(Basket basket);

        Task<bool> SaveChanges();

        Task ClearBasket(Guid basketId);
    }
}