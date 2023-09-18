using Entities.Models;
using Repositories.Contracts;

namespace Repositories.Infrastructure
{
    public class MainProjectRepository : RepositoryBase<MainProject>, IMainProjectRepository
    {
        public MainProjectRepository(RepositoryContext context) : base(context)
        {

        }

        public void AddMainProject(MainProject mainProject) => Create(mainProject);

        public void DeleteMainProject(MainProject mainProject) => Delete(mainProject);

        public IQueryable<MainProject> GetAllMainProjects(bool trackChanges)
            => FindAll(trackChanges);

        public MainProject GetOneMainProjectById(Guid id, bool trackChanges)
            => FindByCondition(b => b.MainProjectId.Equals(id), trackChanges).SingleOrDefault();

        public void UpdateMainProject(MainProject mainProject) => Update(mainProject);
    }
}
