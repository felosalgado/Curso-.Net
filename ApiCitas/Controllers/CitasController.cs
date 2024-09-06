using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCitas.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly ICitaService _citaService;

        /// <summary>
        /// Constructor CitasController
        /// </summary>
        /// <param name="citaService"></param>
        public CitasController(ICitaService citaService)
        {
            _citaService = citaService;
        }

        /// <summary>
        /// Obtiene todas las citas
        /// </summary>
        /// <returns>Lista de Citas</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> GetAllCitas()
        {
            var citas = await _citaService.GetAllCitas();
            return Ok(citas);
        }

        /// <summary>
        /// Obtiene la cita correspondiente al id
        /// </summary>
        /// <param name="id">Id de la cita</param>
        /// <returns>Un objeto Cita</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Cita>> GetCitaById(int id)
        {
            var cita = await _citaService.GetCitaById(id);
            if (cita == null)
            {
                return NotFound();
            }
            return Ok(cita);
        }

        /// <summary>
        /// Crea una cita 
        /// </summary>
        /// <param name="cita"></param>
        /// <returns>Objeto cita que se creó</returns>
        [HttpPost]
        public async Task<ActionResult> CreateCita(Cita cita)
        {
            var citaId = await _citaService.CreateCita(cita);
            cita.CitaId = citaId;
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.CitaId }, cita);
        }

        /// <summary>
        /// Actualiza una cita
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cita"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCita(int id, Cita cita)
        {
            if (id != cita.CitaId)
            {
                return BadRequest();
            }
            await _citaService.UpdateCita(cita);
            return NoContent();
        }

        /// <summary>
        /// Elimina una cita
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            await _citaService.DeleteCita(id);
            return NoContent();
        }
    }
}
