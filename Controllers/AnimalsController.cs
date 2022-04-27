using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IEnumerable<string> possibleSorting = new List<string> { "name", "type", "admissiondate", "lastname" };

        public AnimalsController(IAnimalClinicsMSSqlDbService animalClinicsMSSqlDbService)
        {
            _service = animalClinicsMSSqlDbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimalsAsync(string sortBy)
        {
            if (sortBy is not null && !possibleSorting.Contains(sortBy.ToLower()))
            {
                return BadRequest("Invalid sorting parameter: " + sortBy);
            }

            IEnumerable<AnimalsGET> result;
            try 
            {
                result = await _service.GetAnimalsAsync(sortBy);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddAnimalAsync(Animal animal)
        {
            throw new NotImplementedException();
            return Ok(await _service.AddAnimalAsync(animal));
        }

    }
}