using EcoPower_Logistics.Data.Data;
using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
    /**
     * This repository class inherits from the generic repository class,
     * and indirectly accesses the DbContext through it.
     * This repository class is of model type Order.
     * It makes us of the CRUD operations of the Generic repository class,
     * and provides implementation for returning either a specific or all Order variables.
     */
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
