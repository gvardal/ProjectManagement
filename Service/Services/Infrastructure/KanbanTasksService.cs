using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services.Infrastructure
{
    public class KanbanTasksService : IKanbanTasksService
    {
        private readonly IRepositoryManager _manager;

        public KanbanTasksService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<KanbanCard> GetAllProjectTasks(bool trackChanges)
        {
            return _manager.KanbanTasks.GetAllTasks(false);
        }
    }
}
