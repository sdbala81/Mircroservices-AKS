using System.Threading.Tasks;
using GlobalTickets.Services.Payment.Model;

namespace GlobalTickets.Services.Payment.Services
{
    public interface IExternalGatewayPaymentService
    {
        Task<bool> PerformPayment(PaymentInfo paymentInfo);
    }
}
