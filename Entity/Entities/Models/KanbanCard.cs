using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class KanbanCard
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public string Assignee { get; set; } = null!;
        public int? ProjectId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
