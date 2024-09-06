using ApiCitas.Models;
using ApiCitas.Services.Citas;
using Microsoft.AspNetCore.Mvc;

namespace ApiCitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaService _citaService;

        public CitaController(ICitaService citaService)
        {
            _citaService = citaService;
        }

        /// <summary>
        /// Obtiene todas las citas.
        /// </summary>
        /// <returns>Lista de citas</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> GetAllCitas()
        {
            var citas = await _citaService.GetAllCitas();
            return Ok(citas);
        }

        /// <summary>
        /// Obtiene una cita por su ID.
        /// </summary>
        /// <param name="id">ID de la cita</param>
        /// <returns>Cita solicitada</returns>
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
        /// Crea una nueva cita.
        /// </summary>
        /// <param name="cita">Datos de la cita a crear</param>
        /// <returns>Cita creada</returns>
        [HttpPost]
        public async Task<ActionResult> CreateCita(Cita cita)
        {
            await _citaService.CreateCita(cita);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.CitaID }, cita);
        }

        /// <summary>
        /// Actualiza una cita existente.
        /// </summary>
        /// <param name="id">ID de la cita a actualizar</param>
        /// <param name="cita">Datos actualizados de la cita</param>
        /// <returns>NoContent si se actualiza correctamente</returns>
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
        /// Elimina una cita por su ID.
        /// </summary>
        /// <param name="id">ID de la cita a eliminar</param>
        /// <returns>NoContent si se elimina correctamente</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCita(int id)
        {
            await _citaService.DeleteCita(id);
            return NoContent();
        }
    }
}
