using EcoPower_Logistics.Data.Data;
using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
    /**
     * This repository class inherits from the generic repository class,
     * and indirectly accesses the DbContext through it.
     * This repository class is of model type Product.
     * It makes us of the CRUD operations of the Generic repository class,
     * and provides implementation for returning either a specific or all Product variables.
     */
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {          
        }

        public Product GetProductById(int? id)
        {
            return GetAll().FirstOrDefault(x => x.ProductId == id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return GetAll().ToList();
        }

        public void AddProduct(Product entity)
        {
            Add(entity);
        }

        public void UpdateProduct(Product entity)
        {
            Update(entity);
        }

        public void RemoveProduct(Product entity)
        {
            Remove(entity);
        }
    }
}
