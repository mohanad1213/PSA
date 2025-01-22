using Database;
using Microsoft.EntityFrameworkCore;

namespace ModularMonolithDoctor.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DocktorDbContext>(options =>
                options.UseInMemoryDatabase("InMemoryDb"));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddControllers().AddApplicationPart(typeof(AppointmentBooking.API.AssemblyReference).Assembly);
            builder.Services.AddControllers().AddApplicationPart(typeof(AppointmentConfirmation.API.AssemblyReference).Assembly);
            builder.Services.AddControllers().AddApplicationPart(typeof(DoctorAppointmentManagement.API.AssemblyReference).Assembly);
            builder.Services.AddControllers().AddApplicationPart(typeof(DoctorAvailability.API.AssemblyReference).Assembly);

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
