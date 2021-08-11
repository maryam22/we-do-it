using System;
using Microsoft.AspNetCore.Mvc;


namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomController : Controller
    {
        // TODO: Add correct parameters to read from the QueryString
        public IActionResult Index()
        {
            // TODO: Implement
            throw new NotImplementedException();
            return Ok("Random number: " + CalculateRandomNumber());
        }

        // TODO: Add an input object called RandomInput as parameter
        // e.g. CalculateRandomNumber(RandomInput input)
        private int CalculateRandomNumber()
        {
            // TODO: Implement random number generation
            // TODO: Use the properties .low and .high from the RandomInput object you've created
            return 0;        
        }
    }
}
