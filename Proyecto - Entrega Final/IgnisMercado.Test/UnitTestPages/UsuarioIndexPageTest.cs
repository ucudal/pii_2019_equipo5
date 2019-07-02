using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Xunit;
using IgnisMercado.Models;
using IgnisMercado.Pages_Actors;

namespace IgnisMercado.Tests
{
    public class UsuariosIndexPageTests
    {
        // A delegate to perform a test action using a pre-configured ApplicationContext
        private delegate Task TestAction(ApplicationContext context);

        // Creates and seeds an ApplicationContext with test data; then calls  test action.
        private async Task PrepareTestContext(TestAction testAction)
        {
            // Database is in memory as long the connection is open
            var connection = new SqliteConnection("DataSource=:memory:");
            try
            {
                connection.Open();

                var options = new DbContextOptionsBuilder<ApplicationContext>()
                    .UseSqlite(connection)
                    .Options;

                // Create the schema in the database and seeds with test data
                using (var context = new ApplicationContext(options))
                {
                    context.Database.EnsureCreated();
                    SeedData.Initialize(context);

                    await testAction(context);
                }
            }
            finally
            {
                connection.Close();
            }
        }

        [Fact]
        public async Task OnGetAsyncPopulatesPageModel()
        {
            // Arrange: seed database with test data
            await PrepareTestContext(async(context) =>
            {
                    var expectedActors = SeedData.GetSeedingUsuarios();

                    // Act: retrieve actors
                    var pageModel = new IndexModel(context);
                    await pageModel.OnGetAsync();

                    // Assert: seeded and retrieved actors match
                    var actualMessages = Assert.IsAssignableFrom<List<Actor>>(pageModel.Usuario);
                    Assert.Equal(
                        expectedActors.OrderBy(a => a.ID).Select(a => a.Name),
                        actualMessages.OrderBy(a => a.ID).Select(a => a.Name));
            });
        }
    }
}