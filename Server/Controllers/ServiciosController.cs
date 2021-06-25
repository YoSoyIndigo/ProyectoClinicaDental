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
    public class ServiciosController : ControllerBase
    {
        private ClinicaDentalDbContext _contexto;

        public ServiciosController(ClinicaDentalDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<ServiciosController>
        [HttpGet]
        public IEnumerable<Servicios> Get()
        {
            return _contexto.Servicios.Include(s => s.Dentistas).ToList();
            
        }

        // GET api/<ServiciosController>/5
        [HttpGet("{id}")]
         public async Task<Servicios> Get(int id)
        {
            return await _contexto.Servicios.Where(r => r.Id == id).FirstOrDefaultAsync();
        }

        // POST api/<ServiciosController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Servicios servicios)
        {
            _contexto.Add(servicios);
            await _contexto.SaveChangesAsync();
            return NoContent();
        }

        // PUT api/<ServiciosController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Servicios servicios)
        {
            _contexto.Entry(servicios).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/<ServiciosController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Servicios losServicios = new Servicios() { Id = id };
            _contexto.Servicios.Remove(losServicios);
            await _contexto.SaveChangesAsync();
            return NoContent();
        }
    }
}
