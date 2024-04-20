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

        public void AddAnimal(Animal animal)
        {
            try
            {
                DataHandler.Verify(animal);
                _animalRepository.AddAnimal(animal);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EditAnimal(Animal animal)
        {
            try
            {
                DataHandler.Verify(animal);
                _animalRepository.EditAnimal(animal);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveAnimal(int idAnimal)
        {
            try
            {
               _animalRepository.RemoveAnimal(idAnimal);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
