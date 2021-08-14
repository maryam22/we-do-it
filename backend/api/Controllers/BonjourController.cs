using System;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BonjourController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            var bonjourService = new BonjourService();

            return Ok(bonjourService.Bonjour());
        }
    }
}