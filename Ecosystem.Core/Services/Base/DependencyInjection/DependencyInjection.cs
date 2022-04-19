using Ecosystem.Services.Base.Implementations;
using Ecosystem.Services.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Ecosystem.Services.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // add the repositories to the DI container
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
