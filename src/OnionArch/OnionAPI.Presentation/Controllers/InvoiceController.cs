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
    public class InvoiceController : ControllerBase
    {
        #region Private && Constructor
        private readonly ILogger<InvoiceController> _logger;
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(
            ILogger<InvoiceController> logger,
            IInvoiceService invoiceService
            )
        {
            _logger = logger;
            _invoiceService = invoiceService;
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
            var product = _invoiceService.GetInvoiceDetails(id);
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
            // TODO: Use proper mapper 

            Product product = new Product(1111,addProductRequest.Name, addProductRequest.Price);
            _invoiceService.Add(product);
            return Ok(product);

        }

        /// <summary>
        /// API: GET Invoice
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public IActionResult List()
        {
            var product = _invoiceService.GetAll();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }
        #endregion
    }
}
