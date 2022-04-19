using Ecosystem.Services.Base.Interfaces;
using StorageManagerService.Context;
using StorageManagerService.DomainServices.Implementations;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Implementations;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // repositories
            services.AddTransient<IRepository<Brand>, ApplicationDbContextRepository<Brand>>();
            services.AddTransient<IRepository<Product>, ApplicationDbContextRepository<Product>>();
            services.AddTransient<IRepository<Store>, ApplicationDbContextRepository<Store>>();
            services.AddTransient<IRepository<ShoppingList>, ApplicationDbContextRepository<ShoppingList>>();
            services.AddTransient<IRepository<ProductPrices>, ApplicationDbContextRepository<ProductPrices>>();

            services.AddScoped<IProductDomainService, ProductDomainService>();
            services.AddScoped<IProductViewService, ProductViewService>();
            services.AddScoped<IProductPriceDomainService, ProductPricesDomainService>();
            services.AddScoped<IProductPriceViewService, ProductPriceViewService>();
            services.AddScoped<IBrandDomainService, BrandDomainService>();
            services.AddScoped<IBrandViewService, BrandViewService>();
            services.AddScoped<IStoreDomainService, StoreDomainService>();
            services.AddScoped<IStoreViewService, StoreViewService>();
            services.AddScoped<IShoppingListDomainService, ShoppingListDomainService>();
            services.AddScoped<IShoppingListViewService, ShoppingListViewService>();

            return services;
        }
    }

}
