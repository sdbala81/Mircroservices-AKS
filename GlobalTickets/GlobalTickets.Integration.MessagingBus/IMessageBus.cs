using GlobalTickets.Integration.Messages;
using System.Threading.Tasks;

namespace GlobalTickets.Integration.MessagingBus
{
    public interface IMessageBus
    {
        Task PublishMessage (IntegrationBaseMessage message, string topicName);
    }
}
