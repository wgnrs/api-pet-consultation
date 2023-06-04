using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consulta.Controllers;
using Consulta.Domain.Services;

namespace Consulta.Application
{
    public class ConsultaApplicationService
    {
        private readonly PessoaService _pessoaService;
        private readonly AnimalService _animalService;
        private readonly ConsultaPetService _consultaService;

        public ConsultaApplicationService(PessoaService pessoaService, AnimalService animalService, ConsultaPetService consultaPetService)
        {
            _pessoaService = pessoaService;
            _animalService = animalService;
            _consultaService = consultaPetService;
        }

        public async Task<List<ConsultaNames>> GetConsultaNames()
        {
            var consultas = await _consultaService.GetAll();

            var consultaNamesList = new List<ConsultaNames>();

            foreach (var consulta in consultas)
            {
                var pessoa = await _pessoaService.GetById(consulta.PessoaId);
                var animal = await _animalService.GetById(consulta.AnimalId);

                var consultaNames = new ConsultaNames
            {
                PessoaNome = pessoa.Nome,
                AnimalNome = animal.Nome,
                ConsultaNome = consulta.Nome
            };

        consultaNamesList.Add(consultaNames);
        }

        return consultaNamesList;
        }
    }
}