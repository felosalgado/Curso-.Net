using ApiCitas.Controllers;
using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace ApiCitasTest.ControllerTests
{
    public class UserControllerTests
    {
        private readonly IUserService _userService;
        private readonly UsersController _controller;

        public UserControllerTests()
        {
            _userService = Substitute.For<IUserService>();
            _controller = new UsersController(_userService);
        }

        [Fact]
        public async Task GetAllUsers_ReturnsOkResult_WithListOfUsers()
        {
            // Arrange
            var testUsers = new List<User>
        {
            new User { IdUser = 1, UserName = "Cristian", UserLastName = "Rojas", UserPhone = "3156066418", UserEmail="test@test.com", UserDateBirth="13-03-2003" },
            new User { IdUser = 2, UserName = "John", UserLastName = "Blue", UserPhone = "3156066418", UserEmail="test@test.com", UserDateBirth="13-03-2003" },
        };
            _userService.GetAllUsers().Returns(testUsers);

            // Act
            var result = await _controller.GetAllUsers();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<User>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
            Assert.Equal("Cristian", returnValue[0].UserName);
            Assert.Equal("John", returnValue[1].UserName);
        }

    }
}
