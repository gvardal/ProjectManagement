using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
    }
}
