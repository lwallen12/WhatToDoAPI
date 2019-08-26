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
    [Route("api/user")]
    [ApiController]
    public class UserDosController : ControllerBase
    {
        private readonly WhatToDoContext _context;

        public UserDosController(WhatToDoContext context)
        {
            _context = context;
        }

        // GET: api/UserDos
        [HttpGet]
        public IEnumerable<UserDo> GetUserDo()
        {
            return _context.UserDo;
        }

        // GET: api/UserDos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserDo([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userDo = await _context.UserDo.FindAsync(id);

            if (userDo == null)
            {
                return NotFound();
            }

            return Ok(userDo);
        }

        // PUT: api/UserDos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserDo([FromRoute] string id, [FromBody] UserDo userDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userDo.Id)
            {
                return BadRequest();
            }

            _context.Entry(userDo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserDoExists(id))
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

        // POST: api/UserDos
        [HttpPost]
        public async Task<IActionResult> PostUserDo([FromBody] UserDo userDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UserDo.Add(userDo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserDo", new { id = userDo.Id }, userDo);
        }

        // DELETE: api/UserDos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserDo([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userDo = await _context.UserDo.FindAsync(id);
            if (userDo == null)
            {
                return NotFound();
            }

            _context.UserDo.Remove(userDo);
            await _context.SaveChangesAsync();

            return Ok(userDo);
        }

        private bool UserDoExists(string id)
        {
            return _context.UserDo.Any(e => e.Id == id);
        }
    }
}