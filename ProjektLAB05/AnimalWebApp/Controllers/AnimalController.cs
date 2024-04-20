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
            try
            {
                _animalService.AddAnimal(animal);
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateAnimal(Animal animal)
        {
            try
            {
                _animalService.EditAnimal(animal);
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteAnimal(int idAnimal)
        {
            try
            {
                _animalService.RemoveAnimal(idAnimal);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
