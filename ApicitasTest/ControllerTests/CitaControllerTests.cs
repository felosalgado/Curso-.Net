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

namespace ApiCitasTest.ControllerTests;

public class CitaControllerTests
{
    private readonly ICitaService _citaService;
    private readonly CitasController _controller;

    public CitaControllerTests()
    {
        _citaService = Substitute.For<ICitaService>();
        _controller = new CitasController(_citaService);
    }

    [Fact]
    public async Task CreateCita_ReturnsCreatedCita_WhenCitaIsValid()
    {
        // Arrange
        var newCita = new Cita
        {
            CitaId = 0,
            UsuarioId = 2,
            Descripcion = "Cita Odontológica",
            FechaCita = new DateTime(2024, 9, 10),
            Lugar = "Hospital 1",
            Estado = "Confirmada"

        };
        _citaService.CreateCita(newCita).Returns(Task.FromResult(9));

        // Act
        var result = await _controller.CreateCita(newCita);

        // Assert
        //var actionResult = Assert.IsType<ActionResult>(result);
        var actionResult = Assert.IsAssignableFrom<ActionResult>(result);
        var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(actionResult);
        var returnedUser = Assert.IsType<Cita>(createdAtActionResult.Value);
        Assert.Equal(newCita.CitaId, returnedUser.CitaId);
        Assert.Equal(newCita.FechaCita, returnedUser.FechaCita);
    }

}
