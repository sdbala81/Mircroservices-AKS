using GlobalTickets.Web.Models.Api;
using System.Collections.Generic;

namespace GlobalTickets.Web.Models.View
{
    public class OrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
