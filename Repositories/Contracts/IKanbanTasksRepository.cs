using Entities.Models;

namespace Repositories.Contracts
{
    public interface IKanbanTasksRepository
    {
        IQueryable<KanbanCard> GetAllTasks(bool trackChanges);
    }
}
