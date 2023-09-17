using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Data.Repositories;

namespace EcoPower_Logistics.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProductById(int? id)
        {
            return _productRepository.GetProductById(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public void AddProduct(Product entity)
        {
            _productRepository.AddProduct(entity);
        }

        public void UpdateProduct(Product entity)
        {
            _productRepository.UpdateProduct(entity);
        }

        public void RemoveProduct(Product entity)
        {
            _productRepository.RemoveProduct(entity);
        }
    }
}
