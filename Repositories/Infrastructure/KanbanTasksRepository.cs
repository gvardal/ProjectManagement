using Entities.Models;
using Repositories.Contracts;

namespace Repositories.Infrastructure
{
    public class KanbanTasksRepository : RepositoryBase<KanbanCard>, IKanbanTasksRepository
    {
        public KanbanTasksRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<KanbanCard> GetAllTasks(bool trackChanges) => FindAll(trackChanges);
    }
}
