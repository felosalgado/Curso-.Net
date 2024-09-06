using ApiCitas.Controllers;
using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCitasTest.ControllerTests
{
    public class CitasControllerTests
    {
        private readonly ICitasService _ICitasService;
        private readonly CitasController _citasController;
        public CitasControllerTests()
        {
            _ICitasService = Substitute.For<ICitasService>();
            _citasController = new CitasController(_ICitasService);
        }

        [Fact]
        public async Task CreateCitasReturnOk()
        {

            var Cita = new Cita()
            {
                CitaID = 1,
                UsuarioID = 1,
                CitaDescripcion = "Test",
                CitaLugar = "4.6137344, -74.1605376",
                CitaEstado = "Pendiente",
                CitaFecha = DateTime.Now,
                CitaFechaCreacion = DateTime.Now
            };

            await _ICitasService.CreateCitas(Cita);
            var result = await _citasController.CreateCita(Cita);
            var okResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<Cita>(okResult.Value);

        }

        [Fact]
        public async Task CreateCitasReturnBad()
        {
            var Cita = new Cita()
            {
                CitaID = 1,
                UsuarioID = 1,
                CitaDescripcion = "Test",
                CitaLugar = "4.6137344, -74.1605376",
                CitaFecha = DateTime.Now,
                CitaFechaCreacion = DateTime.Now
            };

            await _ICitasService.CreateCitas(Cita);

            var result = await _citasController.CreateCita(Cita);

            var okResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<Cita>(okResult.Value);



        }
    }
}