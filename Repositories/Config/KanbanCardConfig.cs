using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class KanbanCardConfig : IEntityTypeConfiguration<KanbanCard>
    {
        public void Configure(EntityTypeBuilder<KanbanCard> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData
                (
                    new KanbanCard { Id = 1, Title = "BLAZ-29001", Status = "Open", Summary = "Analyze the new requirements gathered from the customer.", Assignee = "Nancy Davloio" },
                    new KanbanCard { Id = 2, Title = "BLAZ-29002", Status = "InProgress", Summary = "Improve application performance", Assignee = "Andrew Fuller" },
                    new KanbanCard { Id = 3, Title = "BLAZ-29003", Status = "Open", Summary = "Arrange a web meeting with the customer to get new requirements.", Assignee = "Janet Leverling" },
                    new KanbanCard { Id = 4, Title = "BLAZ-29004", Status = "InProgress", Summary = "Fix the issues reported in the IE browser.", Assignee = "Janet Leverling" },
                    new KanbanCard { Id = 5, Title = "BLAZ-29005", Status = "Testing", Summary = "Fix the issues reported by the customer.", Assignee = "Steven walker" },
                    new KanbanCard { Id = 6, Title = "BLAZ-29006", Status = "Testing", Summary = "Fix the issues reported in Safari browser.", Assignee = "Nancy Davloio" },
                    new KanbanCard { Id = 7, Title = "BLAZ-29007", Status = "Close", Summary = "Test the application in the IE browser.", Assignee = "Margaret hamilt" },
                    new KanbanCard { Id = 8, Title = "BLAZ-29008", Status = "Testing", Summary = "Testing the issues reported by the customer.", Assignee = "Steven walker" },
                    new KanbanCard { Id = 9, Title = "BLAZ-29009", Status = "Open", Summary = "Show the retrieved data from the server in grid control.", Assignee = "Margaret hamilt" },
                    new KanbanCard { Id = 10, Title = "BLAZ-29010", Status = "InProgress", Summary = "Fix cannot open user’s default database SQL error.", Assignee = "Janet Leverling" },
                    new KanbanCard { Id = 11, Title = "BLAZ-29011", Status = "Testing", Summary = "Fix the issues reported in data binding.", Assignee = "Janet Leverling" },
                    new KanbanCard { Id = 12, Title = "BLAZ-29012", Status = "Close", Summary = "Analyze SQL server 2008 connection.", Assignee = "Andrew Fuller" },
                    new KanbanCard { Id = 13, Title = "BLAZ-29013", Status = "Testing", Summary = "Testing databinding issues.", Assignee = "Margaret hamilt" },
                    new KanbanCard { Id = 14, Title = "BLAZ-29014", Status = "Close", Summary = "Analyze grid control.", Assignee = "Margaret hamilt" },
                    new KanbanCard { Id = 15, Title = "BLAZ-29015", Status = "Close", Summary = "Stored procedure for initial data binding of the grid.", Assignee = "Steven walker" },
                    new KanbanCard { Id = 16, Title = "BLAZ-29016", Status = "Close", Summary = "Analyze stored procedures.", Assignee = "Janet Leverling" },
                    new KanbanCard { Id = 17, Title = "BLAZ-29017", Status = "Testing", Summary = "Testing editing issues.", Assignee = "Nancy Davloio" },
                    new KanbanCard { Id = 18, Title = "BLAZ-29018", Status = "Testing", Summary = "Test editing functionality.", Assignee = "Nancy Davloio" },
                    new KanbanCard { Id = 19, Title = "BLAZ-29019", Status = "Open", Summary = "Enhance editing functionality.", Assignee = "Andrew Fuller" },
                    new KanbanCard { Id = 20, Title = "BLAZ-29020", Status = "InProgress", Summary = "Improve the performance of the editing functionality.", Assignee = "Nancy Davloio" },
                    new KanbanCard { Id = 21, Title = "BLAZ-29021", Status = "Open", Summary = "Arrange web meeting with the customer to show editing demo.", Assignee = "Steven walker" },
                    new KanbanCard { Id = 22, Title = "BLAZ-29022", Status = "Testing", Summary = "Fix the editing issues reported by the customer.", Assignee = "Janet Leverling" },
                    new KanbanCard { Id = 23, Title = "BLAZ-29023", Status = "Testing", Summary = "Fix the issues reported by the customer.", Assignee = "Steven walker" },
                    new KanbanCard { Id = 24, Title = "BLAZ-29024", Status = "Testing", Summary = "Fix the issues reported in Safari browser.", Assignee = "Nancy Davloio" },
                    new KanbanCard { Id = 25, Title = "BLAZ-29025", Status = "Testing", Summary = "Fix the issues reported in data binding.", Assignee = "Janet Leverling" },
                    new KanbanCard { Id = 26, Title = "BLAZ-29026", Status = "Testing", Summary = "Test editing functionality.", Assignee = "Nancy Davloio" },
                    new KanbanCard { Id = 27, Title = "BLAZ-29027", Status = "Testing", Summary = "Test editing feature in the IE browser.", Assignee = "Janet Leverling" } 
                );
        }
    }
}
