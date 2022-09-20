using AutoMapper;
using HotelingServices.Core.Entities;
using HotelingServices.Core.Helper;
using HotelingServices.Core.Interfaces.Repositories;
using HotelingServices.Core.Models;
using HotelingServices.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelingServices.Infrastructure.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public readonly InvoiceDbContext _dbContext;
        public readonly IMapper _mapper;
        public InvoiceRepository(InvoiceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper;
        }
        public async Task<bool> CreateInvoice(InvoiceDto invoice)
        {
           
           _dbContext.Invoices.Add(_mapper.Map<Invoice>(invoice));
           var created = await _dbContext.SaveChangesAsync();
           return  created > 0; 
        }

        public async Task<bool> DeleteInvoice(int id)
        {
            _dbContext.Invoices.Remove(new Invoice() { Id = id });
            var created = await _dbContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<IEnumerable<InvoiceDto>> GetAllInvoice()
        {
            var dbInvoices = await _dbContext.Invoices.ToListAsync();
            return _mapper.Map<IEnumerable<InvoiceDto>>(dbInvoices);
        }

        public async Task<InvoiceDto> GetInvoiceById(int id)
        {
            var entity = await _dbContext.Invoices.FirstOrDefaultAsync(item => item.Id == id);
            //Can convert Entity to Dto by Mapper Or Dto Using helper class
            //return entity.ToDto();
            return _mapper.Map<InvoiceDto>(entity);
        }

        public async Task<bool> UpdateInvoice(InvoiceDto invoice)
        {
            
            var entity = await _dbContext.Invoices.FirstOrDefaultAsync(item => item.InvoiceNo == invoice.InvoiceNo);

            // Validate entity is not null
            if (entity != null)
            {
                var updatedEntity = _mapper.Map<Invoice>(invoice);
                entity = updatedEntity;
                _dbContext.SaveChanges();
            }
            return true;
        }
    }
}
