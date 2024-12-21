using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Domain.RepositoriesContract
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        List<Product> GetProducts();
        Product Insert(Product product);
    }
}
