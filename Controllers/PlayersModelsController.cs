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
    public class PlayersModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PlayersModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PlayersModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayersModel>>> GetPlayersModel()
        {
          if (_context.PlayersModel == null)
          {
              return NotFound();
          }
            return await _context.PlayersModel.ToListAsync();
        }

        // GET: api/PlayersModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayersModel>> GetPlayersModel(long id)
        {
          if (_context.PlayersModel == null)
          {
              return NotFound();
          }
            var playersModel = await _context.PlayersModel.FindAsync(id);

            if (playersModel == null)
            {
                return NotFound();
            }

            return playersModel;
        }

        // PUT: api/PlayersModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayersModel(long id, PlayersModel playersModel)
        {
            if (id != playersModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(playersModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayersModelExists(id))
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

        // POST: api/PlayersModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlayersModel>> PostPlayersModel(PlayersModel playersModel)
        {
          if (_context.PlayersModel == null)
          {
              return Problem("Entity set 'ApplicationDbContext.PlayersModel'  is null.");
          }
            _context.PlayersModel.Add(playersModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPlayersModel), new { id = playersModel.Id }, playersModel);
        }

        // DELETE: api/PlayersModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayersModel(long id)
        {
            if (_context.PlayersModel == null)
            {
                return NotFound();
            }
            var playersModel = await _context.PlayersModel.FindAsync(id);
            if (playersModel == null)
            {
                return NotFound();
            }

            _context.PlayersModel.Remove(playersModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayersModelExists(long id)
        {
            return (_context.PlayersModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
