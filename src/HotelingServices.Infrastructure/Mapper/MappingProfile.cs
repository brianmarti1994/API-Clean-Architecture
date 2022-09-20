using AutoMapper;
using HotelingServices.Core.Entities;
using HotelingServices.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelingServices.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            this.CreateMap<Invoice, InvoiceDto>();
            this.CreateMap<InvoiceDto, Invoice>();
        }
    
    }
}
