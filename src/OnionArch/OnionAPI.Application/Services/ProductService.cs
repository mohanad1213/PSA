using OnionAPI.Application.Abstractions.ServicesContract;
using OnionAPI.Domain.Entities;
using OnionAPI.Domain.RepositoriesContract;

namespace OnionAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
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
