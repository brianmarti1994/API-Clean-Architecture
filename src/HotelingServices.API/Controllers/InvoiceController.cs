using HotelingServices.Core.Interfaces.Services;
using HotelingServices.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelingServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService ?? throw new ArgumentNullException(nameof(invoiceService));
        }

        [HttpGet]
        [Route("getAllInvoices")]
        public async Task<ActionResult<IEnumerable<InvoiceDto>>> GetAllInvoices()
        {
            var response = await _invoiceService.GetAllInvoice().ConfigureAwait(false);
            if (response == null)
            {
                return NoContent();
            }
            return Ok(response);
        }

        [HttpGet]
        [Route("getInvoicesById")]
        public async Task<ActionResult<InvoiceDto>> GetInvoiceById(int id)
        {
            var response = await _invoiceService.GetInvoiceById(id).ConfigureAwait(false);
            if (response == null)
            {
                return NoContent();
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("addInvoice")]
        public async Task<ActionResult<Boolean>> AddInvoices(InvoiceDto invoiceDto)
        {
            var response = await _invoiceService.CreateInvoice(invoiceDto).ConfigureAwait(false);
            if (!response)
            {
                return NoContent();
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("updateInvoice")]
        public async Task<ActionResult<Boolean>> UpdateInvoice(InvoiceDto invoiceDto)
        {
            var response = await _invoiceService.UpdateInvoice(invoiceDto).ConfigureAwait(false);
            if (!response)
            {
                return NoContent();
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("deleteInvoiceById")]
        public async Task<ActionResult<Boolean>> DeleteInvoiceById(int id)
        {
            var response = await _invoiceService.DeleteInvoice(id).ConfigureAwait(false);
            if (!response)
            {
                return NoContent();
            }
            return Ok(response);
        }


    }
}
