using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPVisitorManagement2020.Data;
using ASPVisitorManagement2020.Models;

namespace ASPVisitorManagement2020
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIStaffNamesAPIController : ControllerBase
    {
        private readonly VisitorDbContext _context;

        public APIStaffNamesAPIController(VisitorDbContext context)
        {
            _context = context;
        }

        // GET: api/APIStaffNamesAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StaffNames>>> GetStaffNames()
        {
            return await _context.StaffNames.ToListAsync();
        }

        // GET: api/APIStaffNamesAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StaffNames>> GetStaffNames(int id)
        {
            var staffNames = await _context.StaffNames.FindAsync(id);

            if (staffNames == null)
            {
                return NotFound();
            }

            return staffNames;
        }

        // PUT: api/APIStaffNamesAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaffNames(int id, StaffNames staffNames)
        {
            if (id != staffNames.Id)
            {
                return BadRequest();
            }

            _context.Entry(staffNames).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffNamesExists(id))
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

        // POST: api/APIStaffNamesAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StaffNames>> PostStaffNames(StaffNames staffNames)
        {
            _context.StaffNames.Add(staffNames);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaffNames", new { id = staffNames.Id }, staffNames);
        }

        // DELETE: api/APIStaffNamesAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StaffNames>> DeleteStaffNames(int id)
        {
            var staffNames = await _context.StaffNames.FindAsync(id);
            if (staffNames == null)
            {
                return NotFound();
            }

            _context.StaffNames.Remove(staffNames);
            await _context.SaveChangesAsync();

            return staffNames;
        }

        private bool StaffNamesExists(int id)
        {
            return _context.StaffNames.Any(e => e.Id == id);
        }
    }
}
