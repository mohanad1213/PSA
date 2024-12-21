using OnionAPI.Domain.Entities;
using OnionAPI.Domain.RepositoriesContract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnionAPI.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product( id:1, name:"Laptop", price:1000M),
            new Product(id: 2, name:"Smartphone", price:500M )
        };

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product Insert(Product product)
        {
            _products.Add(product);
            return product;
        }
    }
}
