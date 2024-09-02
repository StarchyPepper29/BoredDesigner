using Microsoft.AspNetCore.Mvc;
using System;

namespace BoredDesigner.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRandomHexCode()
        {
            // Generate a single random hex color code
            string hexCode = GenerateRandomHexCode();

            // Return the hex color code as a JSON response
            return Ok(new { Color = hexCode });
        }

        // Helper method to generate a random hex color code
        private string GenerateRandomHexCode()
        {
            Random random = new Random();
            int colorValue = random.Next(0x1000000); // Generate a random integer between 0x000000 and 0xFFFFFF
            return $"#{colorValue:X6}"; // Convert the integer to a hex code
        }
    }
}
