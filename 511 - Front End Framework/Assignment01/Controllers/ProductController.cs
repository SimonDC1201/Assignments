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
    public class ProductController : ControllerBase
    {
        private readonly NorthwindContext _context;
        public ProductController()
        {
            _context = new NorthwindContext();
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _context.Products.ToList();
        }
    }
}
