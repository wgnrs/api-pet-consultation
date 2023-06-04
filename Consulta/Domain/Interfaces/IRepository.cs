using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consulta.Domain.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}