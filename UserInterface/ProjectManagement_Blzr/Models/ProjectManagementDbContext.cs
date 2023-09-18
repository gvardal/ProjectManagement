using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectManagement_Blzr.Models;

public partial class ProjectManagementDbContext : DbContext
{
    public ProjectManagementDbContext()
    {
    }

    public ProjectManagementDbContext(DbContextOptions<ProjectManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Project> Projects { get; set; }
    public virtual DbSet<KanbanCard> KanbanCards { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<ProjectResource> ProjectResources { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost,5001;Initial Catalog=ProjectManagementDb;User ID=sa;Password=Gv973041*;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MainProject>(entity =>
        {
            entity.Property(e => e.MainProjectId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
