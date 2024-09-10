using ApiCitas.Models;
using ApiCitas.Services;
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
        /// Obtiene todas las citas.
        /// </summary>
        /// <returns>Lista con todas las citas.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Citas>>> GetAllCitas()
        {
            var citas = await _citaService.GetAllCitas();
            return Ok(citas);
        }

        /// <summary>
        /// Obtiene una cita por su ID.
        /// </summary>
        /// <param name="id">ID de la cita.</param>
        /// <returns>Retorna la cita obtenida.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Citas>> GetCitaById(int id)
        {
            var cita = await _citaService.GetCitaById(id);
            if (cita == null)
            {
                return NotFound();
            }
            return Ok(cita);
        }

        /// <summary>
        /// Crea una nueva cita.
        /// </summary>
        /// <param name="cita">Los detalles de la cita a crear.</param>
        /// <returns>Retorna la cita creada.</returns>
        [HttpPost]
        public async Task<ActionResult> CreateCita(Citas cita)
        {
            await _citaService.CreateCita(cita);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.CitaID }, cita);
        }

        /// <summary>
        /// Actualiza/modifica una cita indicada.
        /// </summary>
        /// <param name="id">ID de la cita a actualizar.</param>
        /// <param name="cita">Modelo de la cita con los nuevos datos.</param>
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCita(int id, Citas cita)
        {
            if (id != cita.CitaID)
            {
                return BadRequest();
            }
            await _citaService.UpdateCita(cita);
            return NoContent();
        }

        /// <summary>
        /// Elimina una cita especificada.
        /// </summary>
        /// <param name="id">ID de la cita a eliminar.</param>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCita(int id)
        {
            await _citaService.DeleteCita(id);
            return NoContent();
        }
    }
}
