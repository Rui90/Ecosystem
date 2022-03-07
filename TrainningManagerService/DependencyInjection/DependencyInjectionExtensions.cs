using Ecosystem.Core.Base.Implementations;
using Ecosystem.Core.Base.Interfaces;
using TrainningManagerService.Context;
using TrainningManagerService.DomainServices.Implementations;
using TrainningManagerService.DomainServices.Interfaces;
using TrainningManagerService.Entities.Database;
using TrainningManagerService.ViewServices.Implementations;
using TrainningManagerService.ViewServices.Interfaces;

namespace TrainningManagerService.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // repositories
            services.AddTransient<IRepository<Plan>, ApplicationDbContextRepository<Plan>>();
            services.AddTransient<IRepository<Video>, ApplicationDbContextRepository<Video>>();
            services.AddTransient<IRepository<Author>, ApplicationDbContextRepository<Author>>();

            services.AddScoped<IPlanDomainService, PlanDomainService>();
            services.AddScoped<IVideoDomainService, VideoDomainService>();
            services.AddScoped<IAuthorDomainService, AuthorDomainService>();

            services.AddScoped<IPlanViewService, PlanViewService>();
            services.AddScoped<IVideoViewService, VideoViewService>();
            services.AddScoped<IAuthorViewService, AuthorViewService>();


            return services;
        }
    }
}
