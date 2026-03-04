using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private static List<TaskItem> tasks = new();

        [HttpGet]
        public ActionResult<IEnumerable<TaskItem>> Get()
        {
            return Ok(tasks);
        }

        [HttpPost]
        public ActionResult Create(TaskItem task)
        {
            task.Id = tasks.Count + 1;
            tasks.Add(task);
            return Ok(task);
        }
    }
}