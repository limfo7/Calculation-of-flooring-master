using System.Collections.Generic;

namespace Calculator.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost1 { get; set; }
        public double CostOpt { get; set; }

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public int CoverageTypeId { get; set; }
        public virtual CoverageType CoverageType { get; set; }

        public ICollection<OrderforBuying> OrderforBuyings { get; set; }

        public Product()
        {
            OrderforBuyings = new List<OrderforBuying>();
        }
    }
}
