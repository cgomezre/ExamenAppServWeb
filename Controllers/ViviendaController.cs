using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

using ExamenAppServWeb.Data;
using ExamenAppServWeb.Models;

namespace ExamenAppServWeb.Controllers
{
    [System.Web.Http.RoutePrefix("api/clientes")]
    [ApiController]
    public class ViviendasController : ControllerBase
    {
        private readonly ViviendasContext _context;

        public ViviendasController(ViviendasContext context)
        {
            _context = context;
        }

        // GET: api/viviendas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vivienda>>> GetViviendas()
        {
            return await _context.Viviendas.ToListAsync();
        }

        // GET: api/viviendas/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Vivienda>> GetVivienda(int id)
        {
            var vivienda = await _context.Viviendas.FindAsync(id);
            if (vivienda == null)
            {
                return NotFound();
            }
            return vivienda;
        }

        // POST: api/viviendas
        [HttpPost]
        public async Task<ActionResult<Vivienda>> PostVivienda(Vivienda vivienda)
        {
            _context.Viviendas.Add(vivienda);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetVivienda", new { id = vivienda.Id }, vivienda);
        }

        // PUT: api/viviendas/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVivienda(int id, Vivienda vivienda)
        {
            if (id != vivienda.Id)
            {
                return BadRequest();
            }
            _context.Entry(vivienda).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Viviendas.Any(e => e.Id == id))
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

        // DELETE: api/viviendas/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVivienda(int id)
        {
            var vivienda = await _context.Viviendas.FindAsync(id);
            if (vivienda == null)
            {
                return NotFound();
            }
            _context.Viviendas.Remove(vivienda);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Custom Query 1: Buscar viviendas por número de cuartos
        [HttpGet("search/byRooms/{numCuartos}")]
        public async Task<ActionResult<IEnumerable<Vivienda>>> GetViviendasByRooms(int numCuartos)
        {
            return await _context.Viviendas.Where(v => v.NumCuartos == numCuartos).ToListAsync();
        }

        // Custom Query 2: Buscar viviendas con un tamaño mayor a un valor dado
        [HttpGet("search/bySize/{size}")]
        public async Task<ActionResult<IEnumerable<Vivienda>>> GetViviendasBySize(decimal size)
        {
            return await _context.Viviendas.Where(v => v.Tamano > size).ToListAsync();
        }
    }
}