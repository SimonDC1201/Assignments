using Assignment01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
        private static List<Product> _products;

        //public CartController()
        //{
        //    _products = new List<Product>();
        //}

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}
