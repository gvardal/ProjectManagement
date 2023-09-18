using Repositories.Contracts;

namespace Repositories.Infrastructure
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IMainProjectRepository> _mainProjectRepository;
        private readonly Lazy<IKanbanTasksRepository> _kanbanTasksRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _mainProjectRepository = new Lazy<IMainProjectRepository>(() => new MainProjectRepository(_context));
            _kanbanTasksRepository = new Lazy<IKanbanTasksRepository>(() => new KanbanTasksRepository(_context));
        }

        public IMainProjectRepository MainProject => _mainProjectRepository.Value;
        public IKanbanTasksRepository KanbanTasks => _kanbanTasksRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
