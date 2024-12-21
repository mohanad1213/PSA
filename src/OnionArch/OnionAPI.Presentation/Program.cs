using OnionAPI.Application.Abstractions.ServicesContract;
using OnionAPI.Application.Services;
using OnionAPI.Domain.Entities;
using OnionAPI.Domain.RepositoriesContract;
using OnionAPI.Infrastructure.Repositories;

namespace OnionAPI.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            #region Dependency Injection
            // Application Layer DI
            builder.Services.AddScoped<IProductService, ProductService>();

            // Repo DI
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            #endregion



            var app = builder.Build();

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
        }
    }
}
