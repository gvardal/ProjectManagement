using Repositories.Contracts;
using Services.Contracts;

namespace Services.Infrastructure
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IMainProjectService> _mainProjectService;
        private readonly Lazy<IKanbanTasksService> _kanbanTasksService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _mainProjectService = new Lazy<IMainProjectService>(() => new MainProjectManager(repositoryManager));
            _kanbanTasksService = new Lazy<IKanbanTasksService>(() => new KanbanTasksService(repositoryManager));
        }

        public IMainProjectService MainProjectService => _mainProjectService.Value;

        public IKanbanTasksService KanbanTasksService => _kanbanTasksService.Value;
    }
}
