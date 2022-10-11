﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GlobalTickets.Services.Ordering.Entities;

namespace GlobalTickets.Services.Ordering.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetOrdersForUser(Guid userId);
        Task AddOrder(Order order);
        Task<Order> GetOrderById(Guid orderId);
        Task UpdateOrderPaymentStatus(Guid orderId, bool paid);

    }
}