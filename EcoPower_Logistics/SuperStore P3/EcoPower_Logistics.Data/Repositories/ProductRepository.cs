using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Data;
using EcoPower_Logistics.Data.Models;

namespace EcoPower_Logistics.Data.Repositories
{
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
