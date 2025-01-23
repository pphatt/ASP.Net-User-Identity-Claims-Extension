using Microsoft.EntityFrameworkCore;
using Serilog;
using Server.Infrastructure.Persistence;

namespace Server.API.Extensions;

public static class WebApplicationExtension
{
    public static WebApplication AddSerilog(this WebApplication app)
    {
        // serilog config.
        app.UseSerilogRequestLogging();

        return app;
    }
}
