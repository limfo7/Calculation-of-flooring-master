using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Core.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

        public Manufacturer()
        {
            Products = new List<Product>();
        }
    }
}
