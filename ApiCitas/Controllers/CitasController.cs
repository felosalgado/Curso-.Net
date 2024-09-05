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
        private readonly ICitasService _ICitasService;
        public CitasController(ICitasService citasService)
        {
            _ICitasService = citasService;
        }
        // GET: api/<CitasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Citas>>> GetAllCitas()
        {
            var citas =  await _ICitasService.GetAllCitas();
            return Ok(citas);
        }

        // GET api/<CitasController>/5
        [HttpGet("{id}")]
        public async string Get(int id)
        {
            var cita = await _ICitasService.GetCitasById(id);
            return Ok(cita);
        }

        // POST api/<CitasController>
        [HttpPost]
        public async void Post([FromBody] Citas value)
        {
            var cita = await _ICitasService.CreateCitas(value);
            return Ok(cita);
        }

        // PUT api/<CitasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CitasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
