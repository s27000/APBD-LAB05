using AnimalWebApp.Model;
using AnimalWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalWebApp.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class AnimalController : Controller
    {
        private IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet("animals")]
        public IActionResult GetAnimals(string? orderBy)
        {
            var animals = _animalService.GetAnimals(orderBy);
            return Ok(animals);
        }
        [HttpPost]
        public IActionResult AddAnimal(Animal animal)
        {
            var affectedCount = _animalService.AddAnimal(animal);
            if(affectedCount == 0)
            {
                return BadRequest("Request returned no result");
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAnimal(Animal animal)
        {
            var affectedCount = _animalService.EditAnimal(animal);
            if (affectedCount == 0)
            {
                return BadRequest("Request returned no result");
            }
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteAnimal(int idAnimal)
        {
            var affectedCount = _animalService.RemoveAnimal(idAnimal);
            if(affectedCount == 0)
            {
                return BadRequest("Request returned no result");
            }
            return Ok();
        }
    }
}
