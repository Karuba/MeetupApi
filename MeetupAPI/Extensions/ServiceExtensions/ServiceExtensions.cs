
using MeetupApi.Domain.Interfaces.Repositories;
using MeetupApi.Infrastructure.Business;
using MeetupApi.Infrastructure.Data.Repositories;
using MeetupApi.Infrastructure.Migr.SqlServer;
using MeetupApi.Services.Interfaces;

namespace MeetupAPI.Extensions.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDatabaseContext(this IServiceCollection services,
          IConfiguration configuration) =>
              ConnectionExtension.ConfigureDatabaseContext(services, configuration);
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
    }
}
