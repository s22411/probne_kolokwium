using System.Collections.Generic;
using Models;
using Models.DTOs;

namespace Service
{
    public interface IAnimalClinicsMSSqlDbService
    {
        public IEnumerable<AnimalsGET> GetAnimals(string orderBy);
        public bool AddAnimal(Animal animal);
    }
}