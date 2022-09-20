using HotelingServices.Core.Entities;
using HotelingServices.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelingServices.Core.Helper
{
    public static class InvoiceHelper
    {

        public static InvoiceDto ToDto(this Invoice invoice)
        {
            var InvoiceDto = new InvoiceDto
            {
                InvoiceNo = invoice.InvoiceNo,
                InvoiceDate = invoice.InvoiceDate,
                CustomerName = invoice.CustomerName,
                CustomerEmail = invoice.CustomerEmail,
                CustomerAddress = invoice.CustomerAddress,
                CustomerContact = invoice.CustomerContact,
                Adults = invoice.Adults,
                Kids = invoice.Kids,
                TotalGuest = invoice.TotalGuest,
                CheckInDate = invoice.CheckInDate,
                CheckOutDate = invoice.CheckOutDate,
                VillaSuit = invoice.VillaSuit,
                PaidAmount = invoice.PaidAmount,
                DueAmount = invoice.DueAmount,
                TotalAmount = invoice.TotalAmount,
                Description = invoice.Description,
            };

            return InvoiceDto;
        }
    }
}
