using OnionAPI.Domain.Entities;

namespace OnionAPI.Application.Abstractions.ServicesContract
{
    public interface IInvoiceService
    {
        public Invoice GetInvoiceDetails(int invoiceId);
        public List<Invoice> GetAll();
        public Invoice Add(Product product);
    }
}
