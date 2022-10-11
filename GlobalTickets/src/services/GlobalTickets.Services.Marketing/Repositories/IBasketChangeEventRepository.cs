using System.Threading.Tasks;
using GlobalTickets.Services.Marketing.Entities;

namespace GlobalTickets.Services.Marketing.Repositories
{
    public interface IBasketChangeEventRepository
    {
        Task AddBasketChangeEvent(BasketChangeEvent basketChangeEvent);
    }
}