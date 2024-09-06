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
        /// Obtiene citas de la entidad
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Citas>>> GetAllCitas()
        {
            var citas = await _citaService.GetAllCitas();
            //IQueryable<User> usersAsQueryable = users.AsQueryable();
            //IQueryable<User> filter = usersAsQueryable.Where(e => e.UserName.Equals("Cristian"));

            return Ok(citas);
        }
        /// <summary>
        /// Consulta Citas por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetCitaById(int id)
        {


            var citas = await _citaService.GetCitaById(id);
            if (citas == null)
            {
                return NotFound();
            }
            return Ok(citas);
        }
        /// <summary>
        /// Crea las citas
        /// </summary>
        /// <param name="cita"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> CreateCita(Citas cita)
        {
            await _citaService.CreateCita(cita);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.CitaID }, cita);
        }
        /// <summary>
        /// actualiza datos de la cita por ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cita"></param>
        /// <returns></returns>
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
        /// Borra citas por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCita(int id)
        {
            await _citaService.DeleteCita(id);
            return NoContent();
        }
    }
}
