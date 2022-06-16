using System.Collections.Generic;

namespace Assignment01.Models
{
    public class Cart
    {
        public List<Product> products { get; set; }
        public double totalPrice { get; set; }
    }
}
