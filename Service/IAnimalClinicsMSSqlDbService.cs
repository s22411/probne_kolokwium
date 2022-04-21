using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using Models.DTOs;

namespace Service
{
    public interface IAnimalClinicsMSSqlDbService
    {
        Task<IEnumerable<AnimalsGET>> GetAnimalsAsync(string sortBy);
        Task<bool> AddAnimalAsync(Animal animal);
    }
}