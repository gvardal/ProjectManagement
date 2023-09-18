using Entities.Models;

namespace Services.Contracts
{
    public interface IKanbanTasksService
    {
        IEnumerable<KanbanCard> GetAllProjectTasks(bool trackChanges);
    }
}
