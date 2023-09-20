using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcoPower_Logistics.Data.Data;
using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Service.Services;

namespace Controllers
{
    [Authorize]
    public class OrderDetailsController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailsController(ICustomerService customerService, IProductService productService, IOrderService orderService, IOrderDetailService orderDetailService)
        {
            _customerService = customerService;
            _productService = productService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _orderDetailService = orderDetailService;
        }

        // GET: OrderDetails
        public async Task<IActionResult> Index()
        {
            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId");
            return View(_orderDetailService.GetAllOrderDetails().ToList());
        }

        // GET: OrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId");
            var orderDetail = _orderDetailService.GetOrderDetailById(id);

            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // GET: OrderDetails/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId");
            return View();
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderDetailsId,OrderId,ProductId,Quantity,Discount")] OrderDetail orderDetail)
        {
            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId", orderDetail.ProductId);
            return RedirectToAction("Index");
        }

        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = _orderDetailService.GetOrderDetailById(id);

            if (orderDetail == null)
            {
                return NotFound();
            }

            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId", orderDetail.OrderId);
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId", orderDetail.ProductId);
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderDetailsId,OrderId,ProductId,Quantity,Discount")] OrderDetail orderDetail)
        {
            if (id != orderDetail.OrderDetailsId)
            {
                return NotFound();
            }

            try
            {
                _orderDetailService.UpdateOrderDetail(orderDetail);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderDetailExists(orderDetail.OrderDetailsId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["OrderId"] = new SelectList(_orderService.GetAllOrders(), "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_productService.GetAllProducts(), "ProductId", "ProductId");
            var orderDetail = _orderDetailService.GetOrderDetailById(id);

            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderDetail = _orderDetailService.GetOrderDetailById(id);
            _orderDetailService.RemoveOrderDetail(orderDetail);
            return RedirectToAction("Index");
        }

        private bool OrderDetailExists(int id)
        {
            return _orderDetailService.GetOrderDetailById(id) != null;
        }
    }
}
