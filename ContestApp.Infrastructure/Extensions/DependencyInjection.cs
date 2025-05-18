using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ContestApp.Infrastructure.Data;
using ContestApp.Infrastructure.Repositories;
using ContestApp.Domain.Abstractions;

namespace ContestApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(connectionString));

        services.AddScoped<IUnitOfWork, EfUnitOfWork>();

        return services;
    }
}
