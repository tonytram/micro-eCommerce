using BuildingBlocks.Behaviors;
using FluentValidation;
using Marten;

namespace Catalog.API
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(Program).Assembly;
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(assembly);
                config.AddOpenBehavior(typeof(ValidationBehavior<,>));
                config.AddOpenBehavior(typeof(LoggingBehavior<,>));
            });

            services.AddValidatorsFromAssembly(assembly);
            services.AddMarten(opts =>
            {
                opts.Connection(configuration.GetConnectionString("Database")!);
            }).UseLightweightSessions();

            return services;
        }
    }
}
