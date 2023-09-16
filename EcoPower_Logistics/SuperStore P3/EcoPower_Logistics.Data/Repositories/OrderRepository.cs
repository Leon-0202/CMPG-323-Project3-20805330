using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Data;
using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SuperStoreContext context) : base(context)
        {
        }

        public Order GetOrderById(int? id)
        {
            return GetAll().FirstOrDefault(x => x.OrderId == id);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return GetAll().ToList();
        }

        public void AddOrder(Order entity)
        {
            Add(entity);
        }

        public void UpdateOrder(Order entity)
        {
            Update(entity);
        }

        public void RemoveOrder(Order entity)
        {
            Remove(entity);
        }
    }
}
