using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCitas.Controllers
{
    /// <summary>
    /// Controlador encargado de manejar las operaciones relacionadas con las citas.
      /// </summary>
    [Route("api/[controller]")]
    [ApiController]

    public class CitasController : ControllerBase
    {
        private readonly ICitasService _ICitasService;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CitasController"/>.
        /// </summary>
        public CitasController(ICitasService citasService)
        {
            _ICitasService = citasService;
        }

        /// <summary>
        /// Obtiene todas las citas.
        /// </summary>
        /// <returns>Lista de citas.</returns>
        /// <response code="200">Retorna todas las citas disponibles.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Cita>>> GetAllCitas()
        {
            var citas = await _ICitasService.GetAllCitas();
            return Ok(citas);
        }

        /// <summary>
        /// Obtiene una cita por su ID.
        /// </summary>
        /// <param name="id">El ID de la cita.</param>
        /// <returns>Detalles de la cita.</returns>
        /// <response code="200">Retorna la cita solicitada.</response>
        /// <response code="404">Si la cita no existe.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Cita>> GetCitaById(int id)
        {
            var cita = await _ICitasService.GetCitasById(id);
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
        /// <returns>La cita creada.</returns>
        /// <response code="201">Retorna la cita creada.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> CreateCita(Cita cita)
        {
            await _ICitasService.CreateCitas(cita);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.CitaID }, cita);
        }

        /// <summary>
        /// Actualiza una cita existente.
        /// </summary>
        /// <param name="id">El ID de la cita a actualizar.</param>
        /// <param name="cita">Los detalles actualizados de la cita.</param>
        /// <response code="204">Cita actualizada exitosamente.</response>
        /// <response code="400">Si el ID no coincide con el de la cita.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdateCita(int id, Cita cita)
        {
            if (id != cita.CitaID)
            {
                return BadRequest();
            }
            await _ICitasService.UpdateCitas(cita);
            return NoContent();
        }

        /// <summary>
        /// Elimina una cita por su ID.
        /// </summary>
        /// <param name="id">El ID de la cita a eliminar.</param>
        /// <response code="204">Cita eliminada exitosamente.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> DeleteCita(int id)
        {
            await _ICitasService.DeleteCitas(id);
            return NoContent();
        }
    }
}
