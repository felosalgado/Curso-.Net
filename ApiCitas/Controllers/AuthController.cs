using ApiCitas.Models;
using ApiCitas.Services.Identity;
using ApiCitas.Models.Identity;
using Microsoft.AspNetCore.Mvc;
using IdentityModel.Client;

namespace ApiCitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly InMemoryUserService _userService;

        public AuthController(InMemoryUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("token")]
        public async Task<IActionResult> GetToken([FromForm] string username, [FromForm] string password)
        {
            var user = await _userService.GetUser(username, password);
            if (user == null)
            {
                return Unauthorized();
            }

            // Aquí deberías generar el token
            var token = await GenerateToken(user);
            return Ok(new { Token = token });
        }

        private async Task<string> GenerateToken(UserIdentity user)
        {
            //var clientHandler = new HttpClientHandler
            //{
            //    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            //};

            //var client = new HttpClient(clientHandler);

            //// Descubrir los endpoints de IdentityServer
            //var disco = await client.GetDiscoveryDocumentAsync("https://localhost:7031"); // Cambia el puerto si es necesario
            //if (disco.IsError)
            //{
            //    throw new Exception(disco.Error);
            //}

            //// Solicitar el token
            //var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            //{
            //    Address = disco.TokenEndpoint,
            //    ClientId = "client",
            //    ClientSecret = "secret",
            //    Scope = "ApiCitas"
            //});

            //if (tokenResponse.IsError)
            //{
            //    throw new Exception(tokenResponse.Error);
            //}

            //return tokenResponse.AccessToken;

            var tokenResponse = "tu_token"; // logica genera token

            return tokenResponse;
        }
    }
}
