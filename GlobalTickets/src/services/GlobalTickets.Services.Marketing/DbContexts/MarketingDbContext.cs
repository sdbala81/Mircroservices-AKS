﻿using GlobalTickets.Services.Marketing.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalTickets.Services.Marketing.DbContexts
{
    public class MarketingDbContext:  DbContext
    {
    public MarketingDbContext(DbContextOptions<MarketingDbContext> options)
        : base(options)
    {
    }

    public DbSet<BasketChangeEvent> BasketChangeEvents { get; set; }
}
}
