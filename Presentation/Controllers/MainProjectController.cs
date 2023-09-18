using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainProjectController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public MainProjectController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllProjects()
        {
            return Ok(_manager.MainProjectService.GetAllMainProjects(false));
        }
    }
}
