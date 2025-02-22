using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/Question3")]
    [ApiController]
    public class Question3 : ControllerBase
    {
        Dictionary<string, int> spicinesslevels = new()
        {
            {"Poblano", 1500},
            {"Mirasol", 6000},
            {"Serrano", 15500},
            {"Cayenne", 40000},
            {"Thai", 75000},
            {"Habanero", 125000}
        };

        /// <summary>
        /// Adapted J2: Calculates the total spice level of a chili recipe based on ingredients.
        /// The spice level is determined by summing the Scoville Heat Units (SHU) of each ingredient.
        /// </summary>
        /// <param name="ingredients">Comma-separated list of peppers</param>
        /// <returns>Total Scoville Heat Units (SHU) for the recipe</returns>
        [HttpGet(template:"ChiliPeppers")]
        public IActionResult CalculateSpice([FromQuery] string ingredients)
        {
            string[] peppers = ingredients.Split(',');
            int totalSpiciness = 0;

            foreach (string pepper in peppers)
            {
                string trimmedPepper = pepper.Trim();
                if (spicinesslevels.ContainsKey(trimmedPepper))
                {
                    totalSpiciness += spicinesslevels[trimmedPepper];
                }
            }

            return Ok(totalSpiciness);
        }
    }
}