using Microsoft.EntityFrameworkCore;
using Calculator.Core.Models;

namespace Calculator.Core.DAL.Context
{
    public class CalculationOfFlooringDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<CoverageType> CoverageTypes { get; set; }
        public DbSet<OrderforBuying> OrderforBuyings { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public CalculationOfFlooringDbContext(DbContextOptions<CalculationOfFlooringDbContext> options)
            : base(options)
        {

        }
    }
}
