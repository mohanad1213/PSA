using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using OnionAPI.Application.Abstractions.ServicesContract;
using OnionAPI.Application.Services;
using OnionAPI.Domain.Entities;
using OnionAPI.Presentation.RequestModel;

namespace OnionAPI.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        #region Private && Constructor
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(
            ILogger<ProductController> logger,
            IProductService productService
            )
        {
            _logger = logger;
            _productService = productService;
        }
        #endregion

        #region End-Points
        /// <summary>
        /// API: GET Product/{id}
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetProductDetails(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }

        /// <summary>
        /// API: Post Product
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        public IActionResult Post(AddProductRequest addProductRequest)
        {
            // Model Mapping
            Product product = new Product(addProductRequest.Name, addProductRequest.Price);
           

            _productService.Add(product);
            return Ok(product);

        }


        /// <summary>
        /// API: GET Product
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public IActionResult List()
        {
            var product = _productService.GetProducts();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }
        #endregion
    }
}
