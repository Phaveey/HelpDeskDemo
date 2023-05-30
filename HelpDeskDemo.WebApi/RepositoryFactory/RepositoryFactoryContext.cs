using HelpDeskDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HelpDeskDemo.WebApi.RepositoryFactory
{
    public class RepositoryFactoryContext : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
            .UseSqlServer(configuration.GetConnectionString("dataConnection"),
            b => b.MigrationsAssembly("HelpDeskDemo.Persistence"));
            return new RepositoryContext(builder.Options);
        }
    }
}
