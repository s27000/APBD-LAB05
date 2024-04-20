using AnimalWebApp.Repository;
using AnimalWebApp.Model;

namespace AnimalWebApp.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public IEnumerable<Animal> GetAnimals(string? orderBy)
        {
            return _animalRepository.GetAnimals(orderBy);
        }

        public int AddAnimal(Animal animal)
        {
            return _animalRepository.AddAnimal(animal);
        }

        public int EditAnimal(Animal animal)
        {
            return _animalRepository.EditAnimal(animal);
        }

        public int RemoveAnimal(int idAnimal)
        {
            return _animalRepository.RemoveAnimal(idAnimal);
        }
    }
}
