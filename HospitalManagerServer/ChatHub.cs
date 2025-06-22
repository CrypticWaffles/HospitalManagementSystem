using Microsoft.AspNetCore.SignalR;

namespace HospitalManagerServer
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // Send the message to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
