using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Server.API.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        // default services.
        services.AddControllers();

        return services;
    }
}
