using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoredDesigner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoodboardController : ControllerBase
    {
        private readonly BoredDesignerContext _context;

        // Inject the BoredDesignerContext in the constructor
        public MoodboardController(BoredDesignerContext context)
        {
            _context = context;
        }

        // GET: api/Moodboard
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Moodboard>>> GetMoodboards()
        {
            return await _context.Moodboards.ToListAsync();
        }

        // GET: api/Moodboard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Moodboard>> GetMoodboard(int id)
        {
            var moodboard = await _context.Moodboards.FindAsync(id);

            if (moodboard == null)
            {
                return NotFound();
            }

            return moodboard;
        }

        // POST: api/Moodboard
        [HttpPost]
        public async Task<ActionResult<Moodboard>> CreateMoodboard(Moodboard moodboard)
        {
            _context.Moodboards.Add(moodboard);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMoodboard), new { id = moodboard.Id }, moodboard);
        }

        // PUT: api/Moodboard/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMoodboard(int id, Moodboard moodboard)
        {
            if (id != moodboard.Id)
            {
                return BadRequest();
            }

            _context.Entry(moodboard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoodboardExists(id))
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

        // DELETE: api/Moodboard/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMoodboard(int id)
        {
            var moodboard = await _context.Moodboards.FindAsync(id);
            if (moodboard == null)
            {
                return NotFound();
            }

            _context.Moodboards.Remove(moodboard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MoodboardExists(int id)
        {
            return _context.Moodboards.Any(e => e.Id == id);
        }
    }
}
