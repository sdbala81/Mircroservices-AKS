using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GlobalTickets.Services.EventCatalog.Entities;

namespace GlobalTickets.Services.EventCatalog.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetEvents(Guid categoryId);
        Task<Event> GetEventById(Guid eventId);
    }
}
