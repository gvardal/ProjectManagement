using Entities.Models;

namespace Services.Contracts
{
    public interface IMainProjectService
    {
        IEnumerable<MainProject> GetAllMainProjects(bool trackChanges);
        MainProject GetMainProjectById(Guid id, bool trackChanges);
        MainProject CreateMainProject(MainProject project);
        void UpdateMainProject(Guid id, MainProject project,bool trackChanges);
        void DeleteMainProject(Guid id, bool trackChanges);
    }
}
