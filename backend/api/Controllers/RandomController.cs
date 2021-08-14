using System;
using api.Models;
using Microsoft.AspNetCore.Mvc;


namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomController : Controller
    {
        // TODO: Add correct parameters to read from the QueryString   
        public IActionResult Index(int low, int high)
        {
            // TODO: Implement
            var newRandomInput = new RandomInput();
            newRandomInput.Low = low;
            newRandomInput.High = high;
            return Ok("Random number: " + CalculateRandomNumber(newRandomInput));
        }

        // TODO: Add an input object called RandomInput as parameter
        // e.g. CalculateRandomNumber(RandomInput input)
        private int CalculateRandomNumber(RandomInput input)
        {
            // TODO: Implement random number generation
            // TODO: Use the properties .low and .high from the RandomInput object you've created
            var random = new Random();
            var randomNumber = random.Next(input.Low, input.High + 1);
            return randomNumber;
        }
    }
}
