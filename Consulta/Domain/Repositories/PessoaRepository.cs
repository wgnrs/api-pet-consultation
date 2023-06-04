using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Consulta.Domain.Repositories
{
    public class PessoaRepository
    {
        private readonly DbContext _context;

        public PessoaRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<Pessoa> GetById(int id)
        {
            return await _context.Set<Pessoa>().FindAsync(id);
        }

        public async Task<List<Pessoa>> GetAll()
        {
            return await _context.Set<Pessoa>().ToListAsync();
        }

        public async Task Create(Pessoa pessoa)
        {
            _context.Set<Pessoa>().Add(pessoa);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Pessoa pessoa)
        {
            _context.Set<Pessoa>().Update(pessoa);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Pessoa pessoa)
        {
            _context.Set<Pessoa>().Remove(pessoa);
            await _context.SaveChangesAsync();
        }
    }    
}