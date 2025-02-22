using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/Question1")]
    [ApiController]
    public class Question1 : ControllerBase
    {
        /// <summary>
        /// Adapted J1: Calculates the final score for the Deliv-e-droid game based on deliveries and collisions.
        /// The score calculation follows:
        /// - Each delivery gives +50 points.
        /// - Each collision deducts -10 points.
        /// - If deliveries are greater than collisions, a bonus of +500 points is awarded.
        /// </summary>
        /// <param name="collisions">Number of collisions encountered</param>
        /// <param name="deliveries">Number of deliveries made</param>
        /// <returns>Final calculated score</returns>
        [HttpPost(template:"Delivedroid")]
        public IActionResult Delivedroid(int collisions, int deliveries)
        {
            int score = (deliveries * 50) - (collisions * 10);
            if (deliveries > collisions)
            {
                score += 500;
            }
            return Ok(score);
        }
    }
}
