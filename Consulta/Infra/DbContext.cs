using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consulta.Domain;
using Microsoft.EntityFrameworkCore;

namespace Consulta.Infra
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<ConsultaPet> Consultas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais das entidades, chaves primárias, associações, etc.

            base.OnModelCreating(modelBuilder);
        }
    }
}