using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ResourceConfig : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(k => k.ResourceId);
            builder.HasData
                (
                    new Resource { ResourceId = 1, FirstName = "Martin", LastName = "Tamer", FullName= "Martin Tamer" },
                    new Resource { ResourceId = 2, FirstName = "Rose", LastName = "Fuller", FullName= "Rose Fuller" },
                    new Resource { ResourceId = 3, FirstName = "Margaret", LastName = "Bunchanan", FullName = "Margaret Buchanan" },
                    new Resource { ResourceId = 4, FirstName = "Fuller", LastName = "King", FullName = "Fuller King" },
                    new Resource { ResourceId = 5, FirstName = "Davolio", LastName = "Fuller", FullName = "Davolio Fuller" },
                    new Resource { ResourceId = 6, FirstName = "Fuller", LastName = "Bunchanan", FullName = "Fuller Buchanan" },
                    new Resource { ResourceId = 7, FirstName = "Jack", LastName = "Davolio" , FullName = "Jack Davolio" },
                    new Resource { ResourceId = 8, FirstName = "Tamer", LastName = "Vinet" , FullName = "Tamer Vinet" },
                    new Resource { ResourceId = 9, FirstName = "Vinnet", LastName = "Fuller" , FullName = "Vinet Fuller" },
                    new Resource { ResourceId = 10, FirstName = "Bergs", LastName = "Anton" , FullName = "Bergs Anton" },
                    new Resource { ResourceId = 11, FirstName = "Construction", LastName = "Supervisior" , FullName = "Construction Supervisor" }
                );
        }
    }
}
