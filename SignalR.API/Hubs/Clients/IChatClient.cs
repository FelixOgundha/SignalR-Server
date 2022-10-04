using SignalR.API.Models;

namespace SignalR.API.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
