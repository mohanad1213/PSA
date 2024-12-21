using OnionAPI.Domain.Entities;
using OnionAPI.Domain.RepositoriesContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Infrastructure.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000M },
            new Product { Id = 2, Name = "Smartphone", Price = 500M }
        };

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
