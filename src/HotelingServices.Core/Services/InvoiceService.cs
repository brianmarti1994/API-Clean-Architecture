using HotelingServices.Core.Interfaces.Repositories;
using HotelingServices.Core.Interfaces.Services;
using HotelingServices.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelingServices.Core.Services
{
    //The business layer
    public class InvoiceService : IInvoiceService
    {
        public readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository ?? throw new ArgumentNullException(nameof(invoiceRepository));
        }

        public async Task<bool> CreateInvoice(InvoiceDto invoice)
        {
          
            return  await _invoiceRepository.CreateInvoice(invoice);
        }

        public async Task<bool> DeleteInvoice(int id)
        {
            return await _invoiceRepository.DeleteInvoice(id);
        }

        public async Task<IEnumerable<InvoiceDto>> GetAllInvoice()
        {
            return await _invoiceRepository.GetAllInvoice();
        }

        public async Task<InvoiceDto> GetInvoiceById(int id)
        {
            return await _invoiceRepository.GetInvoiceById(id);
        }

        public async Task<bool> UpdateInvoice(InvoiceDto invoice)
        {
            return await _invoiceRepository.UpdateInvoice(invoice);
        }
    }
}
