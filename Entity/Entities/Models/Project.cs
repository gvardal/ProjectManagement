using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Duration { get; set; }
        public int Progress { get; set; }
        public int? ParentId { get; set; }               
        
    }
}
