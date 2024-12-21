using OnionAPI.Application.Abstractions.ServicesContract;
using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        public Invoice Add(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public Invoice GetInvoiceDetails(int invoiceId)
        {
            throw new NotImplementedException();
        }
    }
}
