using AnimalWebApp.Repository;
using Microsoft.Extensions.Configuration;

namespace AnimalWebAppTest
{
    [TestClass]
    public class AnimalWebAppTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IConfiguration configuration;
            AnimalRepository repository = new AnimalRepository(configuration("ConnectionStrings:DefaultConnection"));
        }
    }
}