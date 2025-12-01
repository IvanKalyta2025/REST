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

        private static int nextId = 1;

        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok(tasks);
        }
        [HttpPost]
        public IActionResult CreateTask([FromBody] TaskItem newTask)
        {
            if (string.IsNullOrWhiteSpace(newTask.Title))
                return BadRequest("Title is required");

            newTask.Id = nextId++;
            tasks.Add(newTask);

            return CreatedAtAction(nameof(GetTasks), new { id = newTask.Id }, newTask);
        }

    }
}