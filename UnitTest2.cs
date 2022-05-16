using FinalCinema.Controllers;
using FinalCinema.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace UnitTests
{
    public class UnitTest2
    {
        [Fact]
        public async void Test1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CinemaAPIContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-JNBPJFN; Database=FinalCinemaDB; Trusted_Connection=True; MultipleActiveResultSets=true");

            var controller = new GenresController(new CinemaAPIContext(optionsBuilder.Options));

            // Act
            var result = await controller.GetGenres();

            // Assert
            Assert.Contains(result.Value, g => g.GenreName.Equals("Action"));

        }
    }
}