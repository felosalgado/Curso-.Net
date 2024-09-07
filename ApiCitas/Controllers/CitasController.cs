using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly ICitasService _citasService;

        public CitasController(ICitasService citaService)
        {
            _citasService = citaService;
        }


        /// <summary>
        /// Se obtienen todos las citas asignadas
        /// </summary>
        /// <returns>Agenta general de citas</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> GetAllCitas()
        {
            var citas = await _citasService.GetAllCitas();
            return Ok(citas);
        }


        /// <summary>
        /// Se obtiene la información de una cita consultada por el ID
        /// </summary>
        /// <returns>Agenta de una cita específica</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Cita>> GetCitaById(int id)
        {
            var cita = await _citasService.GetCitaById(id);
            if (cita == null)
            {
                return NotFound();
            }
            return Ok(cita);
        }


        /// <summary>
        /// Crea una nuevo registro de cita
        /// </summary>
        /// <returns>Cita creada</returns>
        [HttpPost]
        public async Task<ActionResult> CreateCita(Cita cita)
        {
            await _citasService.CreateCita(cita);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.CitaID }, cita);
        }


        /// <summary>
        /// Acualiza una cita determinada
        /// </summary>
        /// <returns>Cita actualizada</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCita(int id, Cita cita)
        {
            if (id != cita.CitaID)
            {
                return BadRequest();
            }
            await _citasService.UpdateCita(cita);
            return NoContent();
        }


        /// <summary>
        /// Elimina una citas determinada
        /// </summary>
        /// <returns>Citas cancelada</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCita(int id)
        {
            await _citasService.DeleteCita(id);
            return NoContent();
        }
    }
}
