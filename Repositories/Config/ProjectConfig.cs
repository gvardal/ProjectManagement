using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.ProjectId);
            builder.HasData
                (
                    new Project() { ProjectId = 1, TaskName = "Product concept ", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), Duration = "5days" },
                    new Project() { ProjectId = 2, TaskName = "Define the product usage", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), Duration = "3", Progress = 30, ParentId = 1 },
                    new Project() { ProjectId = 3, TaskName = "Define the target audience", EndDate = new DateTime(2021, 04, 04), Progress = 40, ParentId = 1 },
                    new Project() { ProjectId = 4, TaskName = "Prepare product sketch and notes", StartDate = new DateTime(2021, 04, 05), Duration = "2", Progress = 30, ParentId = 1 },
                    new Project() { ProjectId = 5, TaskName = "Concept approval", StartDate = new DateTime(2021, 04, 08), EndDate = new DateTime(2021, 04, 08), Duration = "0", ParentId = 1 },
                    new Project() { ProjectId = 6, TaskName = "Market research", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 30 },
                    new Project() { ProjectId = 7, TaskName = "Demand analysis", Duration = "4", Progress = 40, ParentId = 6 },
                    new Project() { ProjectId = 8, TaskName = "Customer strength", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 12), Duration = "4", Progress = 30, ParentId = 7 },
                    new Project() { ProjectId = 9, TaskName = "Market opportunity analysis", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 012), Duration = "4", ParentId = 7 },
                    new Project() { ProjectId = 10, TaskName = "Competitor analysis", StartDate = new DateTime(2021, 04, 15), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 30, ParentId = 6 },
                    new Project() { ProjectId = 11, TaskName = "Product strength analysis", StartDate = new DateTime(2021, 04, 15), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 40, ParentId = 6 },
                    new Project() { ProjectId = 12, TaskName = "Research completed", StartDate = new DateTime(2021, 04, 18), EndDate = new DateTime(2021, 04, 18), Duration = "0", Progress = 30, ParentId = 6 },
                    new Project() { ProjectId = 13, TaskName = "Product design and development", StartDate = new DateTime(2021, 04, 19), EndDate = new DateTime(2021, 05, 16), Duration = "20" },
                    new Project() { ProjectId = 14, TaskName = "Functionality design", StartDate = new DateTime(2021, 04, 19), EndDate = new DateTime(2021, 04, 23), Duration = "3", Progress = 30, ParentId = 13 },
                    new Project() { ProjectId = 15, TaskName = "Quality design", StartDate = new DateTime(2021, 04, 19), EndDate = new DateTime(2021, 04, 23), Duration = "3", Progress = 40, ParentId = 13 },
                    new Project() { ProjectId = 16, TaskName = "Define reliability", StartDate = new DateTime(2021, 04, 24), EndDate = new DateTime(2021, 04, 25), Duration = "2", Progress = 30, ParentId = 13 },
                    new Project() { ProjectId = 17, TaskName = "Identifying raw materials", StartDate = new DateTime(2021, 04, 24), EndDate = new DateTime(2021, 04, 25), Duration = "2", ParentId = 13 },
                    new Project() { ProjectId = 18, TaskName = "Define cost plan", StartDate = new DateTime(2021, 04, 26), EndDate = new DateTime(2021, 04, 29), Duration = "2", Progress = 30, ParentId = 13 },
                    new Project() { ProjectId = 19, TaskName = "Estimate manufacturing cost", StartDate = new DateTime(2021, 04, 26), EndDate = new DateTime(2021, 04, 29), Duration = "2", Progress = 40, ParentId = 18 },
                    new Project() { ProjectId = 20, TaskName = "Estimate selling cost", StartDate = new DateTime(2021, 04, 26), EndDate = new DateTime(2021, 04, 29), Duration = "2", Progress = 30, ParentId = 18 },
                    new Project() { ProjectId = 21, TaskName = "Development of final design", StartDate = new DateTime(2021, 04, 30), EndDate = new DateTime(2021, 05, 08), Duration = "7", ParentId = 13 },
                    new Project() { ProjectId = 22, TaskName = "Develop dimensions and design", StartDate = new DateTime(2021, 04, 30), EndDate = new DateTime(2021, 05, 01), Duration = "2", Progress = 30, ParentId = 21 },
                    new Project() { ProjectId = 23, TaskName = "Develop designs to meet industry", StartDate = new DateTime(2021, 05, 02), EndDate = new DateTime(2021, 05, 03), Duration = "2", Progress = 40, ParentId = 21 },
                    new Project() { ProjectId = 24, TaskName = "Include all the details", StartDate = new DateTime(2021, 05, 06), EndDate = new DateTime(2021, 05, 08), Duration = "3", Progress = 30, ParentId = 21 },
                    new Project() { ProjectId = 25, TaskName = "CAD - Computer Aided Design", StartDate = new DateTime(2021, 05, 09), EndDate = new DateTime(2021, 05, 13), Duration = "3" },
                    new Project() { ProjectId = 26, TaskName = "CAM - Computer Aided Manufacturing", StartDate = new DateTime(2021, 05, 14), EndDate = new DateTime(2021, 05, 16), Duration = "3", Progress = 30 },
                    new Project() { ProjectId = 27, TaskName = "Finalize the design", StartDate = new DateTime(2021, 04, 16), EndDate = new DateTime(2021, 04, 16), Duration = "0", Progress = 40 },
                    new Project() { ProjectId = 28, TaskName = "Prototype testing", StartDate = new DateTime(2021, 05, 17), EndDate = new DateTime(2021, 05, 22), Duration = "4", Progress = 30 },
                    new Project() { ProjectId = 29, TaskName = "Include feedback", StartDate = new DateTime(2021, 05, 17), EndDate = new DateTime(2021, 05, 22), Duration = "4" },
                    new Project() { ProjectId = 30, TaskName = "Manufacturing", StartDate = new DateTime(2021, 05, 23), EndDate = new DateTime(2021, 05, 29), Duration = "5", Progress = 30 },
                    new Project() { ProjectId = 31, TaskName = "Assembling material into finished goods", StartDate = new DateTime(2021, 05, 30), EndDate = new DateTime(2021, 06, 05), Duration = "5", Progress = 40 },
                    new Project() { ProjectId = 32, TaskName = "Final product development", StartDate = new DateTime(2021, 06, 06), EndDate = new DateTime(2021, 06, 13), Duration = "6", Progress = 30 },
                    new Project() { ProjectId = 33, TaskName = "Important improvement", StartDate = new DateTime(2021, 06, 06), EndDate = new DateTime(2021, 06, 10), Duration = "3", ParentId = 32 },
                    new Project() { ProjectId = 34, TaskName = "Customer testing and feedback", StartDate = new DateTime(2021, 06, 11), EndDate = new DateTime(2021, 06, 13), Duration = "3", Progress = 30, ParentId = 32 },
                    new Project() { ProjectId = 35, TaskName = "Final product development", StartDate = new DateTime(2021, 06, 14), EndDate = new DateTime(2021, 06, 19), Duration = "4", Progress = 40 },
                    new Project() { ProjectId = 36, TaskName = "Important improvement", StartDate = new DateTime(2021, 06, 14), EndDate = new DateTime(2021, 06, 19), Duration = "4", Progress = 30, ParentId = 35 },
                    new Project() { ProjectId = 37, TaskName = "Address any unforeseen issues", StartDate = new DateTime(2021, 06, 14), EndDate = new DateTime(2021, 06, 19), Duration = "4", Progress = 30, ParentId = 35 },
                    new Project() { ProjectId = 38, TaskName = "Finalize the product ", StartDate = new DateTime(2021, 06, 20), EndDate = new DateTime(2021, 07, 01), Duration = "8", Progress = 40 },
                    new Project() { ProjectId = 39, TaskName = "Branding the product", StartDate = new DateTime(2021, 06, 20), EndDate = new DateTime(2021, 06, 25), Duration = "4", Progress = 30, ParentId = 38 },
                    new Project() { ProjectId = 40, TaskName = "Marketing and presales", StartDate = new DateTime(2021, 06, 26), EndDate = new DateTime(2021, 07, 01), ParentId = 38, Duration = "4" }
                );
        }
    }
}
