using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consulta.Domain.Interfaces;
using Consulta.Domain.Repositories;

namespace Consulta.Domain.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly AnimalRepository _animalRepository;

        public AnimalService(AnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task<Animal> GetById(int id)
        {
            return await _animalRepository.GetById(id);
        }

        public async Task<List<Animal>> GetAll()
        {
            return await _animalRepository.GetAll();
        }

        public async Task Create(Animal animal)
        {
            await _animalRepository.Create(animal);
        }

        public async Task Update(Animal animal)
        {
            await _animalRepository.Update(animal);
        }

        public async Task Delete(Animal animal)
        {
            await _animalRepository.Delete(animal);
        }
    }
}