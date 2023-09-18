namespace Services.Contracts
{
    public interface IServiceManager
    {
        IMainProjectService MainProjectService { get; }
        IKanbanTasksService KanbanTasksService { get; }
    }
}
