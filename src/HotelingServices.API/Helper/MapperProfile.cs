using AutoMapper;
using HotelingServices.Core.Entities;
using HotelingServices.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelingServices.API.Helper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Invoice, InvoiceDto>();
        }
    }
}
