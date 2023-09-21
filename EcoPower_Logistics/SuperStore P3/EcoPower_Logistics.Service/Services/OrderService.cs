using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Data.Repositories;

namespace EcoPower_Logistics.Service.Services
{
    /** 
     * This class is part of the service layer that is positioned between the repository layer,
     * and controller layer.
     * It provides flexibility to the controllers, making it easier for them to pull information
     * from multiple repositories.
     * It also further abstracts the controllers from the data access logic.
     * This service class is implemented specifically on Order.
     */
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order GetOrderById(int? id)
        {
            return _orderRepository.GetOrderById(id);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public void AddOrder(Order entity)
        {
            _orderRepository.AddOrder(entity);
        }

        public void UpdateOrder(Order entity)
        {
            _orderRepository.UpdateOrder(entity);
        }

        public void RemoveOrder(Order entity)
        {
            _orderRepository.RemoveOrder(entity);
        }
    }
}
