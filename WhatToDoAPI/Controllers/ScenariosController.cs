using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Clash;
using WhatToDoAPI.Models;

namespace WhatToDoAPI.Controllers
{
    [Route("api/scenario")]
    [ApiController]
    public class ScenariosController : ControllerBase
    {
        private readonly WhatToDoContext _context;

        public ScenariosController(WhatToDoContext context)
        {
            _context = context;
        }

        // GET: api/Scenarios
        [HttpGet]
        public IEnumerable<Scenario> GetScenario()
        {
            return _context.Scenario;
        }

        // GET: api/Scenarios/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetScenario([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var scenario = await _context.Scenario.FindAsync(id);

            if (scenario == null)
            {
                return NotFound();
            }

            return Ok(scenario);
        }

        // PUT: api/Scenarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScenario([FromRoute] int id, [FromBody] Scenario scenario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != scenario.Id)
            {
                return BadRequest();
            }

            _context.Entry(scenario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScenarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Scenarios
        [HttpPost]
        public async Task<IActionResult> PostScenario([FromBody] Scenario scenario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Scenario.Add(scenario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScenario", new { id = scenario.Id }, scenario);
        }

        // DELETE: api/Scenarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScenario([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var scenario = await _context.Scenario.FindAsync(id);
            if (scenario == null)
            {
                return NotFound();
            }

            _context.Scenario.Remove(scenario);
            await _context.SaveChangesAsync();

            return Ok(scenario);
        }

        private bool ScenarioExists(int id)
        {
            return _context.Scenario.Any(e => e.Id == id);
        }
    }
}