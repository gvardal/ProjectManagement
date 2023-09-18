using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    internal class MainProjectConfig : IEntityTypeConfiguration<MainProject>
    {
        public void Configure(EntityTypeBuilder<MainProject> builder)
        {
            builder.HasKey(x => x.MainProjectId);
        }
    }
}
