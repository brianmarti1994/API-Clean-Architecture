using HotelingServices.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelingServices.Infrastructure.Context
{
    public class InvoiceDbContext:DbContext
    {
        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> option): base (option)
        {

        }

        public virtual  DbSet<Invoice> Invoices { get; set; }
    }
}
