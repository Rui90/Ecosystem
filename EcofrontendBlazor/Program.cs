using Ecofrontend;
using Ecofrontend.Services.StorageService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IBrandService, BrandService>();

await builder.Build().RunAsync();
