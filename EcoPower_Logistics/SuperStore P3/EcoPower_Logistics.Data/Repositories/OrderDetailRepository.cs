using EcoPower_Logistics.Data.Data;
using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
    /**
     * This repository class inherits from the generic repository class,
     * and indirectly accesses the DbContext through it.
     * This repository class is of model type OrderDetail.
     * It makes us of the CRUD operations of the Generic repository class,
     * and provides implementation for returning either a specific or all OrderDetail variables.
     */
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(SuperStoreContext context) : base(context)
        {
        }

        public OrderDetail GetOrderDetailById(int? id)
        {
            return GetAll().FirstOrDefault(x => x.OrderDetailsId == id);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return GetAll().ToList();
        }

        public void AddOrderDetail(OrderDetail entity)
        {
            Add(entity);
        }

        public void UpdateOrderDetail(OrderDetail entity)
        {
            Update(entity);
        }

        public void RemoveOrderDetail(OrderDetail entity)
        {
            Remove(entity);
        }
    }
}
