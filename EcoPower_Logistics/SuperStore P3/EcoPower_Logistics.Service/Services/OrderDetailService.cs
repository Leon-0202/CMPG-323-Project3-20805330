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
     * This service class is implemented specifically on OrderDetail.
     */
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public OrderDetail GetOrderDetailById(int? id)
        {
            return _orderDetailRepository.GetOrderDetailById(id);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _orderDetailRepository.GetAllOrderDetails();
        }

        public void AddOrderDetail(OrderDetail entity)
        {
            _orderDetailRepository.AddOrderDetail(entity);
        }

        public void UpdateOrderDetail(OrderDetail entity)
        {
            _orderDetailRepository.UpdateOrderDetail(entity);
        }

        public void RemoveOrderDetail(OrderDetail entity)
        {
            _orderDetailRepository.RemoveOrderDetail(entity);
        }
    }
}
