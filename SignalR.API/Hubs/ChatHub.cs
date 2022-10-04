using Microsoft.AspNetCore.SignalR;
using SignalR.API.Hubs.Clients;
using SignalR.API.Models;

namespace SignalR.API.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}
