using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Models;
using Models.DTOs;

namespace Service
{
    public class AnimalClinicsMSSqlDbService : IAnimalClinicsMSSqlDbService
    {
        private readonly IConfiguration _configuration;

        public AnimalClinicsMSSqlDbService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool AddAnimal(Animal animal)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AnimalsGET> GetAnimals(string orderBy)
        {
            throw new System.NotImplementedException();
        }

        public string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }

    }
}