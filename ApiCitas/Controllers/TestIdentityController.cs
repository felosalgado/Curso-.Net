using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiCitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestIdentityController : ControllerBase
    {
        [HttpGet]
        //[Authorize]
        public IActionResult Get()
        {
            return Ok("Hello from TestIdentity");
        }
    }
}
