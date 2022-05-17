using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Assignment01.Models;
using Microsoft.Extensions.Logging;

namespace Assignment01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        


        

        //public IActionResult _Layout()
        //{
        //    return View();
        //}
        IActionResult Privacy()
        {
            return View();
        }
    }
}
