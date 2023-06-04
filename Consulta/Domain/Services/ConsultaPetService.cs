using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consulta.Domain.Interfaces;
using Consulta.Domain.Repositories;

namespace Consulta.Domain.Services
{
    public class ConsultaPetService : IConsultaPetService
    {
        private readonly ConsultaPetRepository _consultaPetRepository;

        public ConsultaPetService(ConsultaPetRepository consultaPetRepository)
        {
            _consultaPetRepository = consultaPetRepository;
        }

        public async Task<ConsultaPet> GetById(int id)
        {
            return await _consultaPetRepository.GetById(id);
        }

        public async Task<List<ConsultaPet>> GetAll()
        {
            return await _consultaPetRepository.GetAll();
        }

        public async Task Create(ConsultaPet consultaPet)
        {
            await _consultaPetRepository.Create(consultaPet);
        }

        public async Task Update(ConsultaPet consultaPet)
        {
            await _consultaPetRepository.Update(consultaPet);
        }

        public async Task Delete(ConsultaPet consultaPet)
        {
            await _consultaPetRepository.Delete(consultaPet);
        }
    }    
}