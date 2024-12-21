using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Domain.RepositoriesContract
{
    public interface IInvoiceRepository
    {
        Invoice GetById(int id);
        List<Invoice> GetAll();
        Invoice Insert(Invoice product);
    }
}
