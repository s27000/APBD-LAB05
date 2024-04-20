using AnimalWebApp.Model;

namespace AnimalWebApp.Services
{
    public interface IAnimalService
    {
        IEnumerable<Animal> GetAnimals(string? orderBy);
        void AddAnimal(Animal animal);
        void EditAnimal(Animal animal);
        void RemoveAnimal(int idAnimal);
    }
}
