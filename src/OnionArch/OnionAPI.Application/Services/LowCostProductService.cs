using OnionAPI.Application.Abstractions.ServicesContract;
using OnionAPI.Domain.Entities;
using OnionAPI.Domain.RepositoriesContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Services
{


    internal class LowCostProductService : IProductService
    {
        // this service can Insert only product price 10.00 USD

        private readonly IProductRepository _productRepository;

        public LowCostProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Add(Product product)
        {
            if (product.Price > 10.00)
                throw new Exception("Low Cost Proudct price can't be more than 10.00 USD");
            else
                return this._productRepository.Insert(product);
        }

        public Product GetProductDetails(int productId)
        {
            if (productId <= 0)
                throw new Exception("Product ID is not correct");
            else
                return _productRepository.GetProductById(productId);
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
