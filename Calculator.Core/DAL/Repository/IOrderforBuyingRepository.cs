using Calculator.Core.Models;
using System.Collections.Generic;

namespace Calculator.Core.DAL.Repository
{
    public interface IOrderforBuyingRepository
    {
        void AddNewOrder(OrderforBuying order);
        IEnumerable<OrderforBuying> GetOrders();
        OrderforBuying GetOrderById(int id);
        void DeleteOrderById(int id);
    }
}
