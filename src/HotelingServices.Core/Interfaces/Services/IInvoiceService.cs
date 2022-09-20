using HotelingServices.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelingServices.Core.Interfaces.Services
{
    public interface IInvoiceService
    {
        Task<IEnumerable<InvoiceDto>> GetAllInvoice();

        Task<InvoiceDto> GetInvoiceById(int id);

        Task<bool> CreateInvoice(InvoiceDto invoice);

        Task<bool> DeleteInvoice(int id);

        Task<bool> UpdateInvoice(InvoiceDto invoice);
    }
}
