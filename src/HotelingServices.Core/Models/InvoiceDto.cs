using System;
using System.Collections.Generic;
using System.Text;

namespace HotelingServices.Core.Models
{
    //Invoice Dto the json object
    public class InvoiceDto
    {
        public string SrNo { get; set; }

        public string InvoiceNo { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerContact { get; set; }

        public int Adults { get; set; }

        public int Kids { get; set; }

        public int TotalGuest { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public string VillaSuit { get; set; }

        public int PaidAmount { get; set; }

        public int DueAmount { get; set; }

        public int TotalAmount { get; set; }

        public string Description { get; set; }
    }
}
