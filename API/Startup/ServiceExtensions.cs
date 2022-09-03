using Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Startup;
public static class ServiceExtensions
{
    public static void ConfigureEntityFrameworkCore(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Default");
        services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(connectionString));
    }

    public static void ConfigureIdentityCore(this IServiceCollection services)
    {
        var builder = services.AddIdentityCore<IdentityUser>(q => q.User.RequireUniqueEmail = true);

        builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
        builder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
    }
}
