using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Data.Repositories;

namespace EcoPower_Logistics.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order GetOrderById(int? id)
        {
            return _orderRepository.GetAll().FirstOrDefault(x => x.OrderId == id);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll().ToList();
        }

        public void AddOrder(Order entity)
        {
            _orderRepository.Add(entity);
        }

        public void UpdateOrder(Order entity)
        {
            _orderRepository.Update(entity);
        }

        public void RemoveOrder(Order entity)
        {
            _orderRepository.Remove(entity);
        }
    }
}
