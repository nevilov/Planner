﻿using Microsoft.AspNetCore.Mvc;
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
            var voteInfo = await _context.DataPlanners.FindAsync(id);

            if (voteInfo == null) {
                return NotFound();
            }

            return voteInfo;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVoteInfo(string id, DataPlanner dataPlanner) {
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

        // POST: api/VoteInfoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
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
        public async Task<ActionResult<DataPlanner>> DeleteVoteInfo(string id) {
            var voteInfo = await _context.DataPlanners.FindAsync(id);
            if (voteInfo == null) {
                return NotFound();
            }

            _context.DataPlanners.Remove(voteInfo);
            await _context.SaveChangesAsync();

            return voteInfo;
        }

        private bool DataPlannerExists(string id) {
            return _context.DataPlanners.Any(e => e.Id == id);
        }
    }

}
