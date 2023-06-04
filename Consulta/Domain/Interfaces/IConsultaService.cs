using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consulta.Domain.Interfaces
{
    public interface IConsultaService
    {
        Task<ConsultaPet> GetById(int id);
        Task<List<ConsultaPet>> GetAll();
        Task Create(ConsultaPet consultaPet);
        Task Update(ConsultaPet consultaPet);
        Task Delete(ConsultaPet consultaPet);
    }
}