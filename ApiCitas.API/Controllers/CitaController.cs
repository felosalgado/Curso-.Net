using ApiCitas.Application.Contracts;
using ApiCitas.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCitas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaServices _citaServices;

        public CitaController(ICitaServices citaServices)
        {
            _citaServices = citaServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> GetAllCitas()
        {
            var citas = await _citaServices.GetAllCitas();
            if (citas == null)
            {
                return NoContent();
            }
            return Ok(citas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cita>> GetCitaById(int id)
        {
            var cita = await _citaServices.GetCitaById(id);
            if (cita == null)
            {
                return NoContent();
            }
            return Ok(cita);
        }

        [HttpPost]
        public async Task<ActionResult> CreateCita(Cita cita)
        {
            
            var citaResponse = await _citaServices.CreateCita(cita); ;
            if (citaResponse == null)
            {
                return NoContent();
            }
            return Ok(citaResponse);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCita(int idCita, Cita cita)
        {
            if (idCita != cita.CitaID)
            {
                return NoContent();
            }
            var citaResponse = await _citaServices.UpdateCita(cita);
            if (citaResponse == null)
            {
                return NoContent();
            }
            return Ok(citaResponse);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int idCita)
        {
            var citaResponse = await _citaServices.DeleteCita(idCita);
            if (citaResponse == null)
            {
                return NoContent();
            }
            return Ok(citaResponse);
        }
    }
}
