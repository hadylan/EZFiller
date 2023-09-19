using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EZFiller.Models;
using EZFiller.Models.Context;

namespace EZFiller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubsModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClubsModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ClubsModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClubsModel>>> GetClubsModel()
        {
          if (_context.ClubsModel == null)
          {
              return NotFound();
          }
            return await _context.ClubsModel.ToListAsync();
        }

        // GET: api/ClubsModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClubsModel>> GetClubsModel(long id)
        {
          if (_context.ClubsModel == null)
          {
              return NotFound();
          }
            var clubsModel = await _context.ClubsModel.FindAsync(id);

            if (clubsModel == null)
            {
                return NotFound();
            }

            return clubsModel;
        }

        // PUT: api/ClubsModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClubsModel(long id, ClubsModel clubsModel)
        {
            if (id != clubsModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(clubsModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClubsModelExists(id))
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

        // POST: api/ClubsModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClubsModel>> PostClubsModel(ClubsModel clubsModel)
        {
          if (_context.ClubsModel == null)
          {
              return Problem("Entity set 'ApplicationDbContext.ClubsModel'  is null.");
          }
            _context.ClubsModel.Add(clubsModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClubsModel), new { id = clubsModel.Id }, clubsModel);
        }

        // DELETE: api/ClubsModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClubsModel(long id)
        {
            if (_context.ClubsModel == null)
            {
                return NotFound();
            }
            var clubsModel = await _context.ClubsModel.FindAsync(id);
            if (clubsModel == null)
            {
                return NotFound();
            }

            _context.ClubsModel.Remove(clubsModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClubsModelExists(long id)
        {
            return (_context.ClubsModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
