using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class KanbanCardDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter title")]
        public string? Title { get; set; }

        public string? Status { get; set; }

        [Required(ErrorMessage = "Enter Summary")]
        public string? Summary { get; set; }

        [Required(ErrorMessage = "Enter Assignee")]
        public string? Assignee { get; set; }

        public string? Color { get; set; }
        public string? Priority { get; set; }
        public List<string>? ClassName { get; set; }
        public List<string>? CardTags { get; set; }
        public int? ProjectId { get; set; }
        public string? ProjectTitle { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Enter Estimated End Date")]
        public DateTime EstimatedEndDate { get; set; }

        public KanbanCardDto()
        {
            ClassName = new();
            CardTags = new();
        }
    }
}
