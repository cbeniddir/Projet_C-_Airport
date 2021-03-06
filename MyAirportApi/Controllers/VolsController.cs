﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAirport.EF;

namespace MyAirportApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolsController : ControllerBase
    {
        private readonly MyAirportContext _context;

        public VolsController(MyAirportContext context)
        {
            _context = context;
        }

        // GET: api/Vols
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vol>>> GetVols()
        {
            return await _context.Vols.ToListAsync();
        }

        /// <summary>
        /// GET: api/Vols/5?bool bagages
        /// L'option bagages permet d'indiquer si l'on veut voir la liste des bagages du vol ou non
        /// si false bagage = null
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bagage">Indique si l'on veut que la liste des bagages soit incluse dans le résultat</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Vol>> GetVol(int id, [FromQuery] bool bagage = false)
        {
            Vol vol;

            if (bagage)
            {
                vol = await _context.Vols.Include(v => v.Bagages).Where(v => v.VolId == id).FirstAsync();
            }
            else
            {
                vol = await _context.Vols.FindAsync(id);
               // vol = await _context.Vols.Select(v => new { v.Cie, v.Destination, v.Dhc, v.Lig, v.Immatriculation, v.NbPassagers, v.Parking, v.VolId}).FirstAsync(id);
            }

            if (vol == null)
            {
                return NotFound();
            }

            return vol;
            
        }

        // PUT: api/Vols/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVol(int id, Vol vol)
        {
            if (id != vol.VolId)
            {
                return BadRequest();
            }

            _context.Entry(vol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolExists(id))
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

        // POST: api/Vols
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Vol>> PostVol(Vol vol)
        {
            _context.Vols.Add(vol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVol", new { id = vol.VolId }, vol);
        }

        // DELETE: api/Vols/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vol>> DeleteVol(int id)
        {
            var vol = await _context.Vols.FindAsync(id);
            if (vol == null)
            {
                return NotFound();
            }

            _context.Vols.Remove(vol);
            await _context.SaveChangesAsync();

            return vol;
        }

        private bool VolExists(int id)
        {
            return _context.Vols.Any(e => e.VolId == id);
        }
    }
}
