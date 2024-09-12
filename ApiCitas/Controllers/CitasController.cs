﻿using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {

        private readonly ICitaService _citaService;
        public CitasController(ICitaService service)
        {
            _citaService = service;
        }
        /// <summary>
        /// Consulta todas las citas creadas en la base de datos
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Cita>>> GetAllCitas()
        {
            var citas = await _citaService.GetAllCitas();
            //IQueryable<cita> citasAsQueryable = citas.AsQueryable();
            //IQueryable<cita> filter = citasAsQueryable.Where(e => e.citaName.Equals("Cristian"));

            return Ok(citas);
        }

        /// <summary>
        /// -> Obtiene una Cita por Id en la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// Crea una Cita en la base de datos
        /// </summary>
        /// <param name="cita"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> CreateCita(Cita cita)
        {
            await _citaService.CreateCita(cita);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.CitaID }, cita);
        }

        /// <summary>
        /// Modifica una Cita creada en la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cita"></param>
        /// <returns></returns>
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
        /// Elimina Cita de la Base de Datos
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