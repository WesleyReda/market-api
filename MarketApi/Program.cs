using MarketApi.CrossCutting.CommonServices;
using MarketApi.Application.AppServices;
using MarketApi.Application.Extensions;
using MarketApi.Domain.Services;
using MarketApi.Repository.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services
    .AddScopedServicesByBaseServiceType<BaseAppService>()
    .AddScopedServicesByBaseServiceType<BaseService>()
    .AddScopedServicesByBaseServiceType<BaseRepository>();

builder.Services.AddAppAutoMapper();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger()
       .UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "docs";
});

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
