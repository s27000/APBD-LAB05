using AnimalWebApp.Model;

namespace AnimalWebApp.Repository
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAnimals(string? orderBy);
        int AddAnimal(Animal animal);
        int EditAnimal(Animal animal);
        int RemoveAnimal(int idAnimal);
    }
}
