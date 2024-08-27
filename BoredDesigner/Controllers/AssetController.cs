using Microsoft.AspNetCore.Mvc;

namespace BoredDesigner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET: api/hello
        [HttpGet]
        public IActionResult GetHello()
        {
            return Ok("Hello dev!");
        }
    }
}
