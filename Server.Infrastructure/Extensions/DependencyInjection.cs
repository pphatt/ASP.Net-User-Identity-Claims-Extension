using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Server.Application.Common.Interfaces.Persistence;
using Server.Domain.Entity.Identity;
using Server.Infrastructure.Authorization;
using Server.Infrastructure.Persistence;
using Server.Infrastructure.Repositories;

namespace Server.Infrastructure.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabase(configuration);

        services.AddScoped<IIdentityRepository, IdentityRepository>();

        return services;
    }

    internal static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            .EnableSensitiveDataLogging());

        services.AddIdentityApiEndpoints<AppUsers>()
            .AddRoles<IdentityRole<Guid>>()
            .AddClaimsPrincipalFactory<AppUsersClaimsPrincipalFactory>()
            .AddEntityFrameworkStores<AppDbContext>();

        return services;
    }
}
