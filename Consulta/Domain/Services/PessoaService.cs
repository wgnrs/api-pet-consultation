using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consulta.Domain.Interfaces;
using Consulta.Domain.Repositories;

namespace Consulta.Domain.Services
{
    public class PessoaService : IService<Pessoa>
    {
        private readonly PessoaRepository _pessoaRepository;

        public PessoaService(PessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public async Task<Pessoa> GetById(int id)
        {
            return await _pessoaRepository.GetById(id);
        }

        public async Task<List<Pessoa>> GetAll()
        {
            return await _pessoaRepository.GetAll();
        }

        public async Task Create(Pessoa pessoa)
        {
            await _pessoaRepository.Create(pessoa);
        }

        public async Task Update(Pessoa pessoa)
        {
            await _pessoaRepository.Update(pessoa);
        }

        public async Task Delete(Pessoa pessoa)
        {
            await _pessoaRepository.Delete(pessoa);
        }
    }
}