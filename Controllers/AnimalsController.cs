using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public async Task<IActionResult> GetAnimals(string orderBy)
        {
            IEnumerable<AnimalsGET> result;
            try 
            {
                result = await _service.GetAnimalsAsync(orderBy);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
            return Ok(await _service.AddAnimalAsync(animal));
        }

    }
}