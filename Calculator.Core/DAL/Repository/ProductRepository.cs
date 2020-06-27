using Calculator.Core.DAL.Context;
using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Core.DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        public readonly CalculationOfFlooringDbContext calculationOfFlooringDbContext;

        public ProductRepository(CalculationOfFlooringDbContext calculationOfFlooringDbContext)
        {
            this.calculationOfFlooringDbContext = calculationOfFlooringDbContext;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
