using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentMarksDashboardAPI.Models;

namespace StudentMarksDashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectModuleController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SubjectModuleController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SubjectModule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubjectModule>>> GetsubjectModules()
        {
            return await _context.subjectModules.ToListAsync();
        }

        // GET: api/SubjectModule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubjectModule>> GetSubjectModule(int id)
        {
            var subjectModule = await _context.subjectModules.FindAsync(id);

            if (subjectModule == null)
            {
                return NotFound();
            }

            return subjectModule;
        }

        // PUT: api/SubjectModule/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubjectModule(int id, SubjectModule subjectModule)
        {
            if (id != subjectModule.Id)
            {
                return BadRequest();
            }

            _context.Entry(subjectModule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectModuleExists(id))
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

        // POST: api/SubjectModule
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubjectModule>> PostSubjectModule(SubjectModule subjectModule)
        {
            _context.subjectModules.Add(subjectModule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubjectModule", new { id = subjectModule.Id }, subjectModule);
        }

        // DELETE: api/SubjectModule/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubjectModule(int id)
        {
            var subjectModule = await _context.subjectModules.FindAsync(id);
            if (subjectModule == null)
            {
                return NotFound();
            }

            _context.subjectModules.Remove(subjectModule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubjectModuleExists(int id)
        {
            return _context.subjectModules.Any(e => e.Id == id);
        }
    }
}
