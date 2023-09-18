using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement_Blzr.Models;

namespace ProjectManagement_Blzr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private ProjectManagementDbContext _context;

        public ProjectController(ProjectManagementDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public object Get()
        {
            List<ProjectDto> mainProjects = new();
            List<Project> projects = _context.Projects.ToList();
            if (projects.Count > 0)
            {
                foreach (var project in projects.Take(15))
                {
                    mainProjects.Add(new ProjectDto
                    {
                        ProjectId = project.ProjectId,
                        TaskName = project.TaskName,
                        StartDate = project.StartDate,
                        EndDate = project.EndDate,
                        Duration = project.Duration,
                        Progress = project.Progress,
                        ParentId = project.ParentId
                    });
                }
            }

            if (mainProjects.Count > 0)
            {
                foreach (var mainProject in mainProjects)
                {
                    List<ProjectResourceDto> resources = new();
                    List<ProjectResource> res = _context.ProjectResources
                        .Where(x => x.ProjectId.Equals(mainProject.ProjectId)).ToList();
                    if (res.Count > 0)
                    {
                        foreach (var resource in res)
                        {
                            mainProject.ProjectResources.Add(new ProjectResourceDto { ResourceId = resource.ResourceId });
                        }

                    }

                }
            }

            return new { Items = mainProjects, Count = mainProjects.Count };
        }

        [HttpPost]
        public void Post([FromBody] List<ProjectDto> projects)
        {
            foreach (var project in projects)
            {
                Project _newProject = new Project()
                {
                    TaskName = project.TaskName,
                    StartDate = project.StartDate,
                    EndDate = project.EndDate,
                    Duration = project.Duration,
                    Progress = project.Progress,
                    ParentId = project.ParentId
                };
                _context.Projects.Add(_newProject);
                AddProjectResource(project.ProjectId, project.ProjectResources);
            }
            _context.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] ProjectDto project)
        {
            if (ModelState.IsValid)
            {
                Project? _project = _context.Projects.Where(x => x.ProjectId.Equals(project.ProjectId)).FirstOrDefault();
                if (_project != null)
                {
                    _project.TaskName = project.TaskName;
                    _project.StartDate = project.StartDate;
                    _project.EndDate = project.EndDate;
                    _project.Duration = project.Duration;
                    _project.Progress = project.Progress;
                    _project.ParentId = project.ParentId;
                    _context.SaveChanges();
                    DelProjectResources(project.ProjectId);
                    AddProjectResource(project.ProjectId, project.ProjectResources);
                }
            }
        }


        [HttpDelete("{List<ProjectDto>}")]
        public void Delete([FromBody] List<ProjectDto> projects)
        {
            foreach (var project in projects)
            {
                Project? _project = _context.Projects.Where(x => x.ProjectId.Equals(project.ProjectId)).First();
                _context.Projects.Remove(_project);
                DelProjectResources(project.ProjectId);
            }
            _context.SaveChanges();
        }


        [HttpGet]
        [Route("Resources")]
        public List<Resource> GetResources()
        {
            return _context.Resources.ToList();
        }

        private void DelProjectResources(int projectId)
        {
            List<ProjectResource> _resources = _context.ProjectResources.Where(x => x.ProjectId.Equals(projectId)).ToList();
            if (_resources.Count > 0)
            {
                foreach (var resource in _resources)
                {
                    var res = _context.ProjectResources.Where(x => x.ProjectId.Equals(resource.ProjectId)
                                && x.ResourceId.Equals(resource.ResourceId)).FirstOrDefault();
                    if (res != null)
                    {
                        _context.ProjectResources.Remove(res);
                        _context.SaveChanges();
                    }
                }
            }

        }

        private void AddProjectResource(int projectId, List<ProjectResourceDto> projectResources)
        {
            foreach (var resource in projectResources)
            {
                ProjectResource _projectResouce = new();
                _projectResouce.ProjectId = projectId;
                _projectResouce.ResourceId = resource.ResourceId;
                _projectResouce.Unit = resource.Unit;
                _projectResouce.Group = resource.Group;
                _context.Add(_projectResouce);
                _context.SaveChanges();
            }

        }
    }
}
