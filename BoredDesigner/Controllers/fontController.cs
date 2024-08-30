using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using FontApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FontApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FontController : ControllerBase
    {
        private readonly string _jsonFilePath = "./Tools/fonts.json"; // Path to your JSON file

        [HttpGet]
        public IActionResult GetRandomFont()
        {
            try
            {
                // Read the JSON file content
                string jsonContent = System.IO.File.ReadAllText(_jsonFilePath);

                // Deserialize the JSON content into a WebFontList object
                WebFontList webFontList = JsonConvert.DeserializeObject<WebFontList>(jsonContent);

                // Check if there are any fonts in the list
                if (webFontList.Items == null || webFontList.Items.Count == 0)
                {
                    return NotFound("No fonts found.");
                }

                // Create a random number generator
                Random random = new Random();

                // Select a random font from the list
                int randomIndex = random.Next(webFontList.Items.Count);
                WebFont randomFont = webFontList.Items[randomIndex];

                // Select a random variant (URL) for the selected font
                string randomVariantKey = GetRandomKey(randomFont.Files, random);
                string randomFontUrl = randomFont.Files[randomVariantKey];

                // Create an anonymous object with the font family and URL
                var result = new
                {
                    Family = randomFont.Family,
                    Variant = randomVariantKey,
                    Url = randomFontUrl
                };

                // Return the result as a JSON response
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // Helper method to get a random key from a dictionary
        private string GetRandomKey(Dictionary<string, string> dictionary, Random random)
        {
            List<string> keys = dictionary.Keys.ToList();
            int randomIndex = random.Next(keys.Count);
            return keys[randomIndex];
        }
    }
}
