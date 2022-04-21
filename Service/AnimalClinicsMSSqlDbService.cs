using System.Collections.Generic;
using System.Threading.Tasks;
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

        public Task<bool> AddAnimalAsync(Animal animal)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AnimalsGET>> GetAnimalsAsync(string orderBy)
        {
            
        }

        public string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }

    }
}