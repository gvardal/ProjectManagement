using Entities.Models;

namespace Repositories.Contracts
{
    public interface IMainProjectRepository : IRepositoryBase<MainProject>
    {
        IQueryable<MainProject> GetAllMainProjects(bool trackChanges);
        MainProject GetOneMainProjectById(Guid id, bool trackChanges);
        void AddMainProject(MainProject mainProject);
        void UpdateMainProject (MainProject mainProject);
        void DeleteMainProject (MainProject mainProject);
    }
}
