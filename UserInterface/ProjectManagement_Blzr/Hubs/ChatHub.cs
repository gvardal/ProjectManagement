using Microsoft.AspNetCore.SignalR;

namespace ProjectManagement_Blzr.Hubs;

public class ChatHub : Hub
{
    public Task SendMessage(string user, string message)
    {
        return Clients.All.SendAsync(method: "ReceiveMessage", user, message);
    }
}
