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
        /// <summary>
        /// Obtiene todas las citas
        /// </summary>
        /// <returns> Retorna una lista de usuarios </returns>
        // GET: api/<CitasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Citas>>> GetAllCitas()
        {
            var citas = await _ICitasService.GetAllCitas();
            return Ok(citas);
        }
        /// <summary>
        /// Obtiene una cita especifica
        /// </summary>
        /// <param name="id">Parametro Id de la cita especifica</param>
        /// <returns>Retorna una cita especifica</returns>
        // GET api/<CitasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCitasById(int id)
        {
            var cita = await _ICitasService.GetCitasById(id);
            if (cita == null)
            {
                return NotFound();
            }
            return Ok(cita);
        }
        /// <summary>
        /// Crea una nueva cita
        /// </summary>
        /// <param name="value">Modelo de la nueva cita</param>
        /// <returns> retorna la cita creada</returns>
        // POST api/<CitasController>
        [HttpPost]
        public async Task<ActionResult> CreateCitas(Citas value)
        {
            var cita = await _ICitasService.CreateCitas(value);
            return CreatedAtAction(nameof(GetCitasById), new {id = value.CitaID}, value);
        }
        /// <summary>
        /// Actualiza una cita especifica
        /// </summary>
        /// <param name="id"> Id de la cita a actualizar</param>
        /// <param name="value"> modelo de la cita a actualizar </param>
        /// <returns>No retorna nada</returns>
        // PUT api/<CitasController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCitas(int id, Citas  value)
        {
            if(id != value.CitaID)
            {
                return BadRequest();
            }
            await _ICitasService.UpdateCitas(value);
            return NoContent();
        }
        /// <summary>
        /// Elimina una cita especifica
        /// </summary>
        /// <param name="id"> id de la cita a eliminar</param>
        /// <returns>No retorna nada</returns>
        // DELETE api/<CitasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCitas(int id)
        {
            await _ICitasService.DeleteCitas(id);
            return NoContent();
        }
    }
}
