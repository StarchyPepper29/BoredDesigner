using Microsoft.AspNetCore.Mvc;

namespace BoredDesigner.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextureController : ControllerBase
    {
        

        [HttpGet]
        public IActionResult GetRandomTexture()
        {
            
            string textureImageURL =getARandomNumber() + ".jpg";
            
            
            return Ok(new { Url = textureImageURL });
        }

        private int getARandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
        
    }
}
