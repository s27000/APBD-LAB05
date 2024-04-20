﻿using AnimalWebApp.Model;

namespace AnimalWebApp.Services
{
    public interface IAnimalService
    {
        IEnumerable<Animal> GetAnimals(string? orderBy);
        int AddAnimal(Animal animal);
        int EditAnimal(Animal animal);
        int RemoveAnimal(int idAnimal);
    }
}
