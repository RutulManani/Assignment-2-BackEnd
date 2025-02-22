using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/Question4")]
    [ApiController]
    public class Question4 : ControllerBase
    {
        /// <summary>
        /// Problem J2-Epidemiology (2020 Junior CCC): Determines the first day when total infections exceed a given population.
        /// </summary>
        /// <param name="people">Total peoplen</param>
        /// <param name="earlyInfected">Number of initially infected people</param>
        /// <param name="spreadNum">Rate of infection</param>
        /// <returns>First day exceeding population</returns>
        [HttpPost(template:"Epidemiology")]
        public IActionResult Epidemiology([FromForm] int people, [FromForm] int earlyInfected, [FromForm] int spreadNum)
        {
            int totalInfected = earlyInfected;
            int dailyInfected = earlyInfected;
            int day = 0;

            while (totalInfected <= people)
            {
                day++;
                dailyInfected *= spreadNum;
                totalInfected += dailyInfected;
            }
            return Ok(day);
        }
    }
}
