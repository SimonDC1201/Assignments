
using assignment02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment02UPDATED.Controllers
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

        [HttpGet]
        public Product Get(int productId)
        {
            return _context.Products.Where(products => products.ProductId == productId).FirstOrDefault();
        }

    }
}
