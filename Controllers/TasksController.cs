using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST.Model;

namespace REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TasksController : ControllerBase
    {
        private static readonly List<TaskItem> tasks = new();


        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok(tasks);
        }
    }
}