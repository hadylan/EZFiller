using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EZFiller.Models;
using EZFiller.Models.Context;

namespace EZFiller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public UserModelsController(ApplicationDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        // GET: api/UserModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUserModel()
        {
          if (_dbContext.UserModel == null)
          {
              return NotFound();
          }
            return await _dbContext.UserModel.ToListAsync();
        }

        // GET: api/UserModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> GetUserModel(long id)
        {
          if (_dbContext.UserModel == null)
          {
              return NotFound();
          }
            var userModel = await _dbContext.UserModel.FindAsync(id);

            if (userModel == null)
            {
                return NotFound();
            }

            return userModel;
        }

        // PUT: api/UserModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserModel(long id, UserModel userModel)
        {
            if (id != userModel.Id)
            {
                return BadRequest();
            }

            _dbContext.Entry(userModel).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserModelExists(id))
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

        // POST: api/UserModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserModel>> PostUserModel(UserModel userModel)
        {
          if (_dbContext.UserModel == null)
          {
              return Problem("Entity set 'UserContext.UserModel'  is null.");
          }
            _dbContext.UserModel.Add(userModel);
            await _dbContext.SaveChangesAsync();

            //return CreatedAtAction("GetUserModel", new { id = userModel.Id }, userModel);
            return CreatedAtAction(nameof(GetUserModel), new { id = userModel.Id }, userModel);
        }

        // DELETE: api/UserModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserModel(long id)
        {
            if (_dbContext.UserModel == null)
            {
                return NotFound();
            }
            var userModel = await _dbContext.UserModel.FindAsync(id);
            if (userModel == null)
            {
                return NotFound();
            }

            _dbContext.UserModel.Remove(userModel);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool UserModelExists(long id)
        {
            return (_dbContext.UserModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
