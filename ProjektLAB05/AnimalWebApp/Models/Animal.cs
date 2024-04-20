using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Animal
    {
        [Required]
        public int IdAnimal;

        [Required]
        [MaxLength(200)]
        public string Name;

        [MaxLength(200)]
        public string Description;

        [Required]
        [MaxLength(200)]
        public string Category;

        [Required]
        [MaxLength(200)]
        public string Area;
    }
}
