using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataPlannersController : ControllerBase
    {
        private readonly PlannerDBContext _context;

        public DataPlannersController(PlannerDBContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataPlanner>>> GetDataPlanners() {
            return await _context.DataPlanners.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DataPlanner>> GetDataPlanners(string id) {
            var planner = await _context.DataPlanners.FindAsync(id);

            if (planner == null) {
                return NotFound();
            }

            return planner;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDataModel(string id, DataPlanner dataPlanner) {
            if (id != dataPlanner.Id) {
                return BadRequest();
            }

            _context.Entry(dataPlanner).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!DataPlannerExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpPost("create")]
        public async Task<IActionResult> Create(PlannerModel model) {

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


        [HttpDelete("{id}")]
        public async Task<ActionResult<DataPlanner>> DeleteDataPlanner(string id) {
            var planner = await _context.DataPlanners.FindAsync(id);
            if (planner == null) {
                return NotFound();
            }

            _context.DataPlanners.Remove(planner);
            await _context.SaveChangesAsync();

            return planner;
        }

        private bool DataPlannerExists(string id) {
            return _context.DataPlanners.Any(e => e.Id == id);
        }
    }

}
