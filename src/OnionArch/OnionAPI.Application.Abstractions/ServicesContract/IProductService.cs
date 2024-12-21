using OnionAPI.Domain.Entities;

namespace OnionAPI.Application.Abstractions.ServicesContract
{
    public interface IProductService
    {
        public Product GetProductDetails(int productId);
        public List<Product> GetProducts();
        public Product Add(Product product);
    }
}
