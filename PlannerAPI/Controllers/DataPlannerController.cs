using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataPlannerController : ControllerBase
    {
        private readonly PlannerDBContext _context;

        public DataPlannerController(PlannerDBContext context) {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<DataPlanner> GetAll() {
            return _context.DataPlanners.Select(plan => new DataPlanner {
                Id = plan.Id,
                Title = plan.Title,
                Description = plan.Description,
                startTodo = plan.startTodo,
                dueTodo = plan.dueTodo,
                Completed = plan.Completed
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DataPlanner>> GetEmployeeInfo(string id) {
            var dataPlanners = await _context.DataPlanners.FindAsync(id);

            if (dataPlanners == null) {
                return NotFound();
            }

            return dataPlanners;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(DataPlanner model) {
            if (model == null) {
                return BadRequest();
            }

            _context.DataPlanners.Add(new DataPlanner {
                Title = model.Title,
                Description = model.Description,
                startTodo = model.startTodo,
                dueTodo = model.dueTodo
            });
            await _context.SaveChangesAsync();

            return Ok();
        }


    }
}