using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProjectResourceConfig : IEntityTypeConfiguration<ProjectResource>
    {
        public void Configure(EntityTypeBuilder<ProjectResource> builder)
        {
            builder.HasKey(k => k.ProjectResourceId);
            builder.HasData
                (
                    new ProjectResource { ProjectResourceId = 1, ProjectId = 2, ResourceId = 1, Unit = 70 },
                    new ProjectResource { ProjectResourceId = 2, ProjectId = 2, ResourceId = 6 },
                    new ProjectResource { ProjectResourceId = 3, ProjectId = 3, ResourceId = 2 },
                    new ProjectResource { ProjectResourceId = 4, ProjectId = 3, ResourceId = 3 },
                    new ProjectResource { ProjectResourceId = 5, ProjectId = 4, ResourceId = 8 },
                    new ProjectResource { ProjectResourceId = 6, ProjectId = 4, ResourceId = 9, Group = "Rose Fuller" },
                    new ProjectResource { ProjectResourceId = 7, ProjectId = 6, ResourceId = 4 },
                    new ProjectResource { ProjectResourceId = 8, ProjectId = 7, ResourceId = 4 },
                    new ProjectResource { ProjectResourceId = 9, ProjectId = 7, ResourceId = 8 },
                    new ProjectResource { ProjectResourceId = 10, ProjectId = 8, ResourceId = 12 },
                    new ProjectResource { ProjectResourceId = 11, ProjectId = 8, ResourceId = 5 }
                );
        }
    }
}
