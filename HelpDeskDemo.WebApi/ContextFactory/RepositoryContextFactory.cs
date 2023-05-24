using Microsoft.EntityFrameworkCore.Design;

namespace HelpDeskDemo.WebApi.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContextFactory>
    {
        public RepositoryContextFactory CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
