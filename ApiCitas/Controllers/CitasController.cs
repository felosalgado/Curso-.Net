using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly ICitaService _citaService;

        public CitasController(ICitaService citaService)
        {
            _citaService = citaService;
        }

        /// <summary>
        /// Obtiene todas las citas
        /// </summary>
        /// <returns>Lista de citas</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> GetAllCitas()
        {
            var citas = await _citaService.GetAllCitas();
            return Ok(citas);
        }

        /// <summary>
        /// Obtiene una cita por ID
        /// </summary>
        /// <param name="id">ID de la cita</param>
        /// <returns>Una cita específica</returns>
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
        /// Crea una nueva cita
        /// </summary>
        /// <param name="cita">Objeto cita</param>
        /// <returns>Resultado de la creación</returns>
        [HttpPost]
        public async Task<ActionResult> CreateCita(Cita cita)
        {
            await _citaService.CreateCita(cita);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.CitaID }, cita);
        }

        /// <summary>
        /// Actualiza una cita existente
        /// </summary>
        /// <param name="id">ID de la cita</param>
        /// <param name="cita">Objeto cita actualizado</param>
        /// <returns>Resultado de la actualización</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCita(int id, Cita cita)
        {
            if (id != cita.CitaID)
            {
                return BadRequest();
            }
            await _citaService.UpdateCita(cita);
            return NoContent();
        }

        /// <summary>
        /// Elimina una cita
        /// </summary>
        /// <param name="id">ID de la cita</param>
        /// <returns>Resultado de la eliminación</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCita(int id)
        {
            await _citaService.DeleteCita(id);
            return NoContent();
        }
    }
}
