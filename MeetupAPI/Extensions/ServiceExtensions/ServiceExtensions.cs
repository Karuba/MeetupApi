
using MeetupApi.Infrastructure.Migr.SqlServer;

namespace MeetupAPI.Extensions.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDatabaseContext(this IServiceCollection services,
          IConfiguration configuration) =>
              ConnectionExtension.ConfigureDatabaseContext(services, configuration);
    }
}
