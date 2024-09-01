using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BoredDesigner.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRandomHexCodes()
        {
            // Generate a list of 5 random hex color codes
            List<string> hexCodes = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                hexCodes.Add(GenerateRandomHexCode());
            }

            // Return the list as a JSON response
            return Ok(new { Colors = hexCodes });
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
