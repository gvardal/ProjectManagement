﻿namespace Entities.DataTransferObjects
{
    public class ProjectDto
    {
        public int ProjectId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Duration { get; set; }
        public int Progress { get; set; }
        public int? ParentId { get; set; }
        public List<ProjectResourceDto> ProjectResources { get; set; }

        public ProjectDto()
        {
            ProjectResources = new();
        }
    }

    public class ProjectResourceDto
    {
        public int ResourceId { get; set; }
        public string? ResourceName { get; set; }
        public double? Unit { get; set; }
        public string? Group { get; set; }
    }

    
}
