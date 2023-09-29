using Entities.DataTransferObjects;
using Microsoft.AspNetCore.SignalR;

namespace ProjectManagement_Blzr.Hubs
{
    public class KanbanHub : Hub
    {
        public Task ChangeStatus(KanbanCardDto kanbanCard)
        {
            return Clients.All.SendAsync(method: "ChangedKanbanCard", kanbanCard);
        }
    }
}
