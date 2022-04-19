using Microsoft.EntityFrameworkCore;
using StorageManagerService.Context;
using StorageManagerService.DependencyInjection;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers()
    .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
builder.Services.AddServices();

var app = builder.Build();
app.UseCors(cors => cors
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true)
               .AllowCredentials()
           );
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
