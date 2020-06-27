using Calculator.Core.DAL.Context;
using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Core.DAL.Repository
{
    public class OrderforBuyingRepository : IOrderforBuyingRepository
    {
        public readonly CalculationOfFlooringDbContext calculationOfFlooringDbContext;

        public OrderforBuyingRepository(CalculationOfFlooringDbContext calculationOfFlooringDbContext)
        {
            this.calculationOfFlooringDbContext = calculationOfFlooringDbContext;
        }

        public void AddNewOrder(OrderforBuying order)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderforBuying GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderforBuying> GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}
