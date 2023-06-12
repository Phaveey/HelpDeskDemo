using HelpDeskDemo.Application.Common;
using HelpDeskDemo.Persistence.Common;
using LogService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HelpDeskDemo.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod()

                );
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services) => services.Configure<IISOptions>(Options => { });

        public static void ConfigureLoggerService(this IServiceCollection services) => services.AddSingleton<ILoggerManager, LoggerManager>();
        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ComfigureSqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(option => option.UseSqlServer(configuration.GetConnectionString("dataConnection")));
        }

    }
}