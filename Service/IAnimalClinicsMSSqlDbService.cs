using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Service
{
    public interface IAnimalClinicsMSSqlDbService
    {
        public IEnumerable<Animal> GetAnimals(string orderBy);
    }
}