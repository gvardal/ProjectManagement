using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services.Infrastructure
{
    public class MainProjectManager : IMainProjectService
    {
        private readonly IRepositoryManager _manager;

        public MainProjectManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public MainProject CreateMainProject(MainProject project)
        {
            if(project is null)
                throw new ArgumentNullException(nameof(project));

            _manager.MainProject.AddMainProject(project);
            _manager.Save();
            return project;
        }

        public void DeleteMainProject(Guid id, bool trackChanges)
        {
            var entity = _manager.MainProject.GetOneMainProjectById(id,trackChanges);
            if (entity is null) 
                throw new Exception($"Main Project with id:{id} cpuld not found");
            _manager.MainProject.Delete(entity);
            _manager.Save();
        }

        public IEnumerable<MainProject> GetAllMainProjects(bool trackChanges)
        {
            return _manager.MainProject.GetAllMainProjects(trackChanges);
        }

        public MainProject GetMainProjectById(Guid id, bool trackChanges)
        {
            return _manager.MainProject.GetOneMainProjectById(id,trackChanges);
        }

        public void UpdateMainProject(Guid id, MainProject project, bool trackChanges)
        {
            var entity = _manager.MainProject.GetOneMainProjectById(id, trackChanges);

            if (entity is null)
                throw new Exception($"Main Project with id:{id} cpuld not found");

            if (project is null)
                throw new ArgumentNullException(nameof(MainProject));
            
            entity.Description = project.Description;
            _manager.MainProject.Update(entity);
            _manager.Save();
        }
    }
}
