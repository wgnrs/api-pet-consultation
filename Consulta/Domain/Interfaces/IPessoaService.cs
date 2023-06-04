using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consulta.Domain.Interfaces
{
    public interface IPessoaService
    {
        Task<Pessoa> GetById(int id);
        Task<List<Pessoa>> GetAll();
        Task Create(Pessoa pessoa);
        Task Update(Pessoa pessoa);
        Task Delete(Pessoa pessoa);
    }
}