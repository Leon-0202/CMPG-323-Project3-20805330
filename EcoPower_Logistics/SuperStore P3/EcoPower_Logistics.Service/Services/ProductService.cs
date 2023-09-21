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
     * This service class is implemented specifically on Product.
     */
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
