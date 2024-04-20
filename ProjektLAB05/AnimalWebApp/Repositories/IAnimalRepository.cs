using AnimalWebApp.Model;

namespace AnimalWebApp.Repository
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAnimals(string? orderBy);
        void AddAnimal(Animal animal);
        void EditAnimal(Animal animal);
        void RemoveAnimal(int idAnimal);
    }
}
