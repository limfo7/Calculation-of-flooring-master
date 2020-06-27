using System.Collections.Generic;

namespace Calculator.Core.Models
{
    public class CoverageType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

        public CoverageType()
        {
            Products = new List<Product>();
        }
    }
}
