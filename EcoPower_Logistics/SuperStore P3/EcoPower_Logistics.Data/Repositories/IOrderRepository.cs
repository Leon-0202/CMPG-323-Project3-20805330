using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Order GetOrderById(int? id);
        IEnumerable<Order> GetAllOrders();
        void AddOrder(Order entity);
        void UpdateOrder(Order entity);
        void RemoveOrder(Order entity);
    }
}
