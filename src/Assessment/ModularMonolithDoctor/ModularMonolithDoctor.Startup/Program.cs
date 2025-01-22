using Database;
using DoctorAppointmentManagement.API.Core.Application;
using DoctorAvailability.Business;
using DoctorAvailability.Business.Abstraction;
using DoctorAvailability.Data;
using DoctorAvailability.Data.Abstraction;
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
                options.UseInMemoryDatabase( "InMemoryDb"));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Moudle 1: Doctor Availability Module
            builder.Services.AddControllers().AddApplicationPart(typeof(DoctorAvailability.API.AssemblyReference).Assembly);

            builder.Services.AddScoped<ITimeSlotRepo, TimeSlotRepo>();
            builder.Services.AddScoped<IDoctorAvailabilityBusiness, DoctorAvailabilityBusiness>();
            #endregion

            builder.Services.AddControllers().AddApplicationPart(typeof(AppointmentBooking.API.AssemblyReference).Assembly);
            builder.Services.AddControllers().AddApplicationPart(typeof(AppointmentConfirmation.API.AssemblyReference).Assembly);

            #region Moudle 1: Doctor Availability Module
            builder.Services.AddControllers().AddApplicationPart(typeof(DoctorAppointmentManagement.API.AssemblyReference).Assembly);

            builder.Services.AddScoped<SlotService>();
            builder.Services.AddScoped<AppointmentService>();
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
