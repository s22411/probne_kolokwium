using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTOs;
using Service;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalClinicsMSSqlDbService _service;

        public AnimalsController(IAnimalClinicsMSSqlDbService animalClinicsMSSqlDbService)
        {
            _service = animalClinicsMSSqlDbService;
        }

        [HttpGet]
        public IEnumerable<AnimalsGET> GetAnimals(string orderBy)
        {
            return _service.GetAnimals(orderBy);
        }

        [HttpPost]
        public bool AddAnimal(Animal animal)
        {
            return _service.AddAnimal(animal);
        }

    }
}