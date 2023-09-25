using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement_Blzr.Models;

namespace ProjectManagement_Blzr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KanbanController : ControllerBase
    {
        private ProjectManagementDbContext _context;

        public KanbanController(ProjectManagementDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public object Get()
        {
            List<KanbanCardDto> cards = new();
            var result = from knb in _context.KanbanCards
                         join pro in _context.Projects on knb.ProjectId equals pro.ProjectId into knb_pro
                         from p in knb_pro.DefaultIfEmpty()
                         select new
                         {
                             Id = knb.Id,
                             Title = knb.Title,
                             Summary = knb.Summary,
                             Status = knb.Status,
                             Assignee = knb.Assignee,
                             CreatedDate = knb.CreatedDate,
                             EstimatedEndDate = knb.EstimatedEndDate,
                             Color = knb.Color,
                             ProjectId = knb.ProjectId,
                             ProjectName = p.TaskName,
                             Priority = knb.Priority,
                         };
            
            if (result.Count() > 0)
            {
                foreach (var card in result)
                {
                    cards.Add(new KanbanCardDto
                    {
                        Id = card.Id,
                        Title = card.Title,
                        Summary = card.Summary,
                        Status = card.Status,
                        Assignee = card.Assignee,
                        CreatedDate = card.CreatedDate,
                        EstimatedEndDate = card.EstimatedEndDate,
                        Color = card.Color,
                        ProjectId = card.ProjectId,
                        ProjectTitle = card.ProjectName,
                        Priority = card.Priority,
                        ClassName = card.Priority != null ? new List<string> { $"e-{card.Priority.ToLower()}" } : null,
                        CardTags = card.EstimatedEndDate.ToString("dd.MM.yyyy")!="01.01.0001" ? new List<string> { $"Estimated End Date : {card.EstimatedEndDate.ToString("dd.MM.yyyy")}" } : new List<string> { },
                    });
                }
            }
            return cards;
        }

        [HttpPost]
        public IActionResult Post([FromBody] KanbanCardDto task)
        {
            KanbanCard _task = new KanbanCard();
            _task.Title = task.Title!;
            _task.Summary = task.Summary!;
            _task.Status = task.Status!;
            _task.Assignee = task.Assignee!;
            _task.CreatedDate = task.CreatedDate!;
            _task.EstimatedEndDate = task.EstimatedEndDate!;
            _task.Color = task.Color!;
            _task.ProjectId = task.ProjectId!;
            _context.KanbanCards.Add(_task);
            _context.SaveChanges();
            return Ok();
        }


        [HttpPut]
        public void Put([FromBody] KanbanCardDto task)
        {
            if (task is not null)
            {
                KanbanCard _task = _context.KanbanCards.Where(x => x.Id.Equals(task.Id)).FirstOrDefault()!;
                if (_task != null)
                {
                    _task.Id = task.Id;
                    _task.Title = task.Title!;
                    _task.Summary = task.Summary!;
                    _task.Status = task.Status!;
                    _context.SaveChanges();
                }
            }
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            KanbanCard _task = _context.KanbanCards.Where(x => x.Id.Equals(id)).FirstOrDefault()!;
            _context.KanbanCards.Remove(_task);
            _context.SaveChanges();
        }
    }
}
