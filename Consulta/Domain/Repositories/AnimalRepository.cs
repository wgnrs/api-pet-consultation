using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consulta.Infra;
using Microsoft.EntityFrameworkCore;

namespace Consulta.Domain.Repositories
{
    public class AnimalRepository
    {
        private readonly DbContext _context;

        public AnimalRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<Animal> GetById(int id)
        {
            return await _context.Set<Animal>().FindAsync(id);
        }

        public async Task<List<Animal>> GetAll()
        {
            return await _context.Set<Animal>().ToListAsync();
        }

        public async Task Create(Animal animal)
        {
            _context.Set<Animal>().Add(animal);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Animal animal)
        {
            _context.Set<Animal>().Update(animal);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Animal animal)
        {
            _context.Set<Animal>().Remove(animal);
            await _context.SaveChangesAsync();
        }
    }
}