using ClinicaDental.Server.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaDental.Shared.Models;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicaDental.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NombreDentistasController : ControllerBase
    {
        private readonly ClinicaDentalDbContext _contexto;

        public NombreDentistasController(ClinicaDentalDbContext contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<NombreDentistasController>
        [HttpGet]
        public IEnumerable<Dentistas> Get()
        {
            return _contexto.Dentistas.ToList();
        }

        // GET api/<NombreDentistasController>/5
        [HttpGet("{id}")]
        public async Task<Dentistas> Get(int id)
        {
            return await _contexto.Dentistas.Where(r =>r.Id == id).FirstOrDefaultAsync();
        }

        // POST api/<NombreDentistasController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Dentistas dentistas)
        {
            _contexto.Add(dentistas);
            await _contexto.SaveChangesAsync();
            return NoContent();
        }

        // PUT api/<NombreDentistasController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Dentistas dentistas)
        {
            _contexto.Entry(dentistas).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/<NombreDentistasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Dentistas losDentistas = new Dentistas() { Id = id };
            _contexto.Dentistas.Remove(losDentistas);
            await _contexto.SaveChangesAsync();
            return NoContent();
        }
    }
}
