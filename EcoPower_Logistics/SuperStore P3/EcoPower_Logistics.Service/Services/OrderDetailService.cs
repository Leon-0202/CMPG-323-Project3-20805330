using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Data.Repositories;

namespace EcoPower_Logistics.Service.Services
{
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
