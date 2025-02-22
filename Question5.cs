using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/Question5")]
    [ApiController]
    public class Question5 : ControllerBase
    {
        /// <summary>
        /// Problem J3: Hidden Palindrome (2016 Junior CCC): Finds the longest palindrome in a given string.
        /// A palindrome is a sequence of characters that reads the same forward and backward.
        /// </summary>
        /// <param name="inputWord">Input string to check Palindrome</param>
        /// <returns>Length of the longest palindrome</returns>
        [HttpPost(template:"HiddenPalindrome")]
        public IActionResult HiddenPalindrome([FromForm] string inputWord)
        {
            int maxLength = 1;
            for (int i = 0; i < inputWord.Length; i++)
            {
                for (int j = i; j < inputWord.Length; j++)
                {
                    string subterm = inputWord.Substring(i, j - i + 1);
                    if (subterm == new string(subterm.Reverse().ToArray()) && subterm.Length > maxLength)
                    {
                        maxLength = subterm.Length;
                    }
                }
            }
            return Ok(maxLength);
        }
    }
}
