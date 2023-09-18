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
            return _context.KanbanCards;
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
