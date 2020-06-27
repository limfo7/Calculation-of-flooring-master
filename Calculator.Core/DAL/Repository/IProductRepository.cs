using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Core.DAL.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void RemoveProduct(int id);
    }
}
