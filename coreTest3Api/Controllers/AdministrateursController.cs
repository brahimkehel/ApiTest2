using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using coreTest3Api.Models;
using Microsoft.AspNetCore.Cors;

namespace coreTest3Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsEnabling")]
    public class AdministrateursController : ControllerBase
    {
        private readonly Pfa_dbContext _context;

        public AdministrateursController(Pfa_dbContext context)
        {
            _context = context;
        }

        // GET: api/Administrateurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrateur>>> GetAdministrateur()
        {
            return await _context.Administrateur.ToListAsync();
        }

        // GET: api/Administrateurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Administrateur>> GetAdministrateur(int id)
        {
            var administrateur = await _context.Administrateur.FindAsync(id);

            if (administrateur == null)
            {
                return NotFound();
            }

            return administrateur;
        }

        // PUT: api/Administrateurs/Modifier/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [Route("Modifier")]
        public async Task<IActionResult> PutAdministrateur(int id, Administrateur administrateur)
        {
            if (id != administrateur.Id)
            {
                return BadRequest();
            }

            _context.Entry(administrateur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministrateurExists(id))
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

        // POST: api/Administrateurs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Route("Ajouter")]
        public async Task<ActionResult<Administrateur>> PostAdministrateur(Administrateur administrateur)
        {
            _context.Administrateur.Add(administrateur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdministrateur", new { id = administrateur.Id }, administrateur);
        }

        // DELETE: api/Administrateurs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Administrateur>> DeleteAdministrateur(int id)
        {
            var administrateur = await _context.Administrateur.FindAsync(id);
            if (administrateur == null)
            {
                return NotFound();
            }

            _context.Administrateur.Remove(administrateur);
            await _context.SaveChangesAsync();

            return administrateur;
        }

        private bool AdministrateurExists(int id)
        {
            return _context.Administrateur.Any(e => e.Id == id);
        }
    }
}
