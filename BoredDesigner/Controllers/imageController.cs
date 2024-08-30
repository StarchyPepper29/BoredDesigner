using Microsoft.AspNetCore.Mvc;

namespace BoredDesigner.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RandomImageController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRandomImage()
        {
            // Generate a random image URL using Lorem Picsum
            string imageUrl = "https://picsum.photos/200/300"; // This generates a random 200x300 image

            return Ok(new { Url = imageUrl });
        }
    }
}
