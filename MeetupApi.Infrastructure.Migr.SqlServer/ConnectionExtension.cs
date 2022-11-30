using MeetupApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MeetupApi.Infrastructure.Migr.SqlServer
{
    public static class ConnectionExtension
    {
        public static void ConfigureDatabaseContext(this IServiceCollection services,
            IConfiguration configuration) =>
                services.AddDbContext<RepositoryContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("SqlServer"), b =>
                        b.MigrationsAssembly("MeetupApi.Infrastructure.Migr.SqlServer")));
    }
}