using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sac.Backend.Login.Data;

namespace Sac.Backend.Login.IoC;

public static class IoCServiceExtension
{
    public static void ConfigureAppDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        ConfigureDbContext(services, configuration);


    }

    private static void ConfigureDbContext(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });
    }
}
