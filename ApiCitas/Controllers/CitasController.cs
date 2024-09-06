using ApiCitas.Models;
using ApiCitas.Services;
using ApiCitas.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly ICitaService _service;

        public CitasController(ICitaService service)
        {
            _service = service;
        }
        /// <summary>
        /// Obtiene todas las citas
        /// </summary>
        /// <returns>Lista de usuarios</returns>

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> Get()
        {
            var users = await _service.GetAllCitas();          

            return Ok(users);
        }
        /// <summary>
        /// Obtiene una cita
        /// </summary>
        /// <returns>Cita</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Cita>> Get(int id)
        {
            var user = await _service.GetCitaById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        /// <summary>
        /// Crea una cita
        /// </summary>        
        [HttpPost]
        public async Task<ActionResult> CreateCita(Cita user)
        {
            await _service.CreateCita(user);
            return CreatedAtAction(nameof(Get), new { id = user.CitaID }, user);
        }
        /// <summary>
        /// Actualiza una cita
        /// </summary>
       
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCita(int id, Cita user)
        {
            if (id != user.CitaID)
            {
                return BadRequest();
            }
            await _service.UpdateCita(user);
            return NoContent();
        }
        /// <summary>
        /// Borra una cita
        /// </summary>        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCita(int id)
        {
            await _service.DeleteCita(id);
            return NoContent();
        }
    }
}
