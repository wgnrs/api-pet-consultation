using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Consulta.Domain.Repositories
{
    public class ConsultaPetRepository
    {
        private readonly DbContext _context;

        public ConsultaPetRepository(DbContext context)
        {
            System.Diagnostics.Debugger.Break();
            _context = context;
        }

        public async Task<ConsultaPet> GetById(int id)
        {
            return await _context.Set<ConsultaPet>().FindAsync(id);
        }

        public async Task<List<ConsultaPet>> GetAll()
        {
            return await _context.Set<ConsultaPet>().ToListAsync();
        }

        public async Task Create(ConsultaPet consultaPet)
        {
            _context.Set<ConsultaPet>().Add(consultaPet);
            await _context.SaveChangesAsync();
        }
        
        public async Task Update(ConsultaPet consultaPet)
        {
            _context.Set<ConsultaPet>().Update(consultaPet);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(ConsultaPet consultaPet)
        {
            _context.Set<ConsultaPet>().Remove(consultaPet);
            await _context.SaveChangesAsync();
        }
    }
}