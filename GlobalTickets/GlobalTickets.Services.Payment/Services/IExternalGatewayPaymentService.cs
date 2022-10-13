using GlobalTickets.Services.Payment.Model;
using System.Threading.Tasks;

namespace GlobalTickets.Services.Payment.Services
{
    public interface IExternalGatewayPaymentService
    {
        Task<bool> PerformPayment(PaymentInfo paymentInfo);
    }
}
