using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class ProjectResource
    {
        [Key]
        public int ProjectResourceId { get; set; }
        public int ProjectId { get; set; }
        public int ResourceId { get; set; }
        public double? Unit { get; set; }
        public string? Group { get; set; }
    }
}
