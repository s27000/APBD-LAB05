using AnimalWebApp.Model;
using System.Text.RegularExpressions;

namespace AnimalWebApp.Services
{
    public static class DataHandler
    {
        public static void Verify(Animal animal)
        {
            if (animal.IdAnimal < 0)
            {
                throw new Exception("IdAnimal is invalid");
            }
            if (!IsStringCharOnly(animal.Name))
            {
                throw new Exception("The Name field is invalid");
            }
            if (!IsStringCharOnly(animal.Description))
            {
                throw new Exception("The Description field is invalid");
            }
            if (!IsStringCharOnly(animal.Category))
            {
                throw new Exception("The Category field is invalid");
            }
            if (!IsStringCharOnly(animal.Area))
            {
                throw new Exception("The Area field is invalid");
            }
        }

        public static bool IsStringCharOnly(string? field)
        {
            return Regex.IsMatch(field, @"^[a-zA-Z]+$");
        }
    }
}
