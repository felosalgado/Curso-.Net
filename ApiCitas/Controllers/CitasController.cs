using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly ICitaService _service;
        public CitasController(ICitaService _citaService)
        {
            _citaService = service; 
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> GetAllcitas()
        {
            var citas = await _citaService.GetAllCitas();
            //IQueryable<cita> citasAsQueryable = citas.AsQueryable();
            //IQueryable<cita> filter = citasAsQueryable.Where(e => e.citaName.Equals("Cristian"));

            return Ok(citas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cita>> GetcitaById(int id)
        {
            var cita = await _citaService.GetcitaById(id);
            if (cita == null)
            {
                return NotFound();
            }
            return Ok(cita);
        }

        [HttpPost]
        public async Task<ActionResult> Createcita(Cita cita)
        {
            await _citaService.Createcita(cita);
            return CreatedAtAction(nameof(GetcitaById), new { id = cita.CitaID }, cita);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Updatecita(int id, Cita cita)
        {
            if (id != cita.CitaID)
            {
                return BadRequest();
            }
            await _citaService.Updatecita(cita);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Deletecita(int id)
        {
            await _citaService.Deletecita(id);
            return NoContent();
        }
    }
}
