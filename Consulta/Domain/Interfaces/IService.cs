using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consulta.Domain.Interfaces
{
    public interface IService <T>
    {
        Task<Animal> GetById(int id);
        Task<List<Animal>> GetAll();
        Task Create(Animal animal);
        Task Update(Animal animal);
        Task Delete(Animal animal);
    }
}