using System.Data.SqlClient;
using AnimalWebApp.Model;

namespace AnimalWebApp.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private IConfiguration _configuration;

        private readonly string[] orderByKeysString = {
                "name",
                "description",
                "category",
                "area"
        };
        private List<string> orderByKeys;

        public AnimalRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            orderByKeys = new List<string>(orderByKeysString);
        }
        public IEnumerable<Animal> GetAnimals(string? orderBy)
        {
            using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
            con.Open();

            using var cmd = new SqlCommand();
            cmd.Connection = con;

            if (orderByKeys.Contains(orderBy))
            {
                cmd.CommandText = "SELECT IdAnimal, Name, Description, Category, Area FROM Animal ORDER BY " + orderBy + " asc";
            }
            else
            {
                cmd.CommandText = "SELECT IdAnimal, Name, Description, Category, Area FROM Animal ORDER BY name asc";
            }

            var dr = cmd.ExecuteReader();
            var animals = new List<Animal>();
            while (dr.Read())
            {
                var animal = new Animal
                {
                    IdAnimal = (int)dr["IdAnimal"],
                    Name = dr["Name"].ToString(),
                    Description = dr["Description"].ToString(),
                    Category = dr["Category"].ToString(),
                    Area = dr["Area"].ToString()
                };
                animals.Add(animal);
            }

            return animals;
        }

        public int AddAnimal(Animal animal)
        {
            using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
            con.Open();

            using var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Animal(IdAnimal, Name, Description, Category, Area) VALUES (@IdAnimal, @Name, @Description, @Category, @Area)";
            cmd.Parameters.AddWithValue("@IdAnimal", animal.IdAnimal);
            cmd.Parameters.AddWithValue("@Name", animal.Name);
            cmd.Parameters.AddWithValue("@Description", animal.Description);
            cmd.Parameters.AddWithValue("@Category", animal.Category);
            cmd.Parameters.AddWithValue("@Area", animal.Area);

            var affectedCount = cmd.ExecuteNonQuery();
            return affectedCount;
        }
        public int EditAnimal(Animal animal)
        {
            using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
            con.Open();

            using var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Animal SET Name = @Name, Description = @Description, Category = @Category, Area = @Area WHERE IdAnimal = @IdAnimal";
            cmd.Parameters.AddWithValue("@Name", animal.Name);
            cmd.Parameters.AddWithValue("@Description", animal.Description);
            cmd.Parameters.AddWithValue("@Category", animal.Category);
            cmd.Parameters.AddWithValue("@Area", animal.Area);
            cmd.Parameters.AddWithValue("@IdAnimal", animal.IdAnimal);

            var affectedCount = cmd.ExecuteNonQuery();
            return affectedCount;
        }
        public int RemoveAnimal(int idAnimal)
        {
            using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
            con.Open();

            using var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Animal WHERE IdAnimal = @IdAnimal";
            cmd.Parameters.AddWithValue("@IdAnimal", idAnimal);

            var affectedCount = cmd.ExecuteNonQuery();
            return affectedCount;
        }
    }
}
