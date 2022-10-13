using System;
using GlobalTickets.Services.EventCatalog.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalTickets.Services.EventCatalog.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetEvents(Guid categoryId);
        Task<Event> GetEventById(Guid eventId);
    }
}
