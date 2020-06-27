using System.Linq;

namespace Calculator.Core.DAL
{
    public static class DbInitializer
    {
        public static void Seed(Context.CalculationOfFlooringDbContext context)
        {
            if (!context.Products.Any())
            {
                context.AddRange(
                    new Models.Product { },
                    new Models.Product { },
                    new Models.Product { },
                    new Models.Product { }
                    );
            }
            if (!context.CoverageTypes.Any())
            {
                context.AddRange(
                    new Models.CoverageType { },
                    new Models.CoverageType { }
                    );
            }
            if (!context.OrderforBuyings.Any())
            {
                context.AddRange(
                    new Models.OrderforBuying { }
                    );
            }
            if (!context.Manufacturers.Any())
            {
                context.AddRange(
                    new Models.Manufacturer { },
                    new Models.Manufacturer { }
                    );
            }

            context.SaveChanges();
        }
    }
}
