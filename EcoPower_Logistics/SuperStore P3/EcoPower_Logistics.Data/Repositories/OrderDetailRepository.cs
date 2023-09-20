using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Data;
using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
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
