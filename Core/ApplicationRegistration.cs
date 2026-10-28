using Microsoft.Extensions.DependencyInjection;
using NoteAPI.Core.Interfaces;
using NoteAPI.Core.Services;

namespace Infrastructure;

public static class ApplicationRegistration
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services)
    {
        services.AddScoped<INoteService, NoteService>();

        return services;
    }
}