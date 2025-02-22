using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/Question2")]
    [ApiController]
    public class Question2 : ControllerBase
    {
        /// <summary>
        /// Problem J1-Tournament Selection (2016 Junior CCC): Determines the tournament group based on the number of wins.
        /// The tournament follows these rules:
        /// - 5 or more wins -> Group 1
        /// - 3 to 4 wins -> Group 2
        /// - 1 to 2 wins -> Group 3
        /// - 0 wins -> Eliminated (-1)
        /// </summary>
        /// <param name="results">Array of game results ('W' for win, 'L' for loss)</param>
        /// <returns>Group number (1-3) or -1 if eliminated</returns>
        [HttpPost(template:"TournamentSelection")]
        public IActionResult TournamentSelection([FromForm] string[] results)
        {
            int wins = results.Count(r => r == "W");
            int group = wins >= 5 ? 1 : wins >= 3 ? 2 : wins >= 1 ? 3 : -1;
            return Ok(group);
        }
    }
}
