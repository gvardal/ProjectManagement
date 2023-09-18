namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IMainProjectRepository MainProject { get; }
        IKanbanTasksRepository KanbanTasks { get; }
        void Save();
    }
}
