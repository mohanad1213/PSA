using AppointmentBooking.Application.Services;
using AppointmentBooking.Application.ServicesAbstraction;
using AppointmentBooking.Domain.RepoAbstraction;
using AppointmentBooking.Infrastructure.Database;
using AppointmentBooking.Infrastructure.Repos;
using Database;
using DoctorAppointmentManagement.API.Core.Application;
using DoctorAvailability.Business;
using DoctorAvailability.Business.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace ModularMonolithDoctor.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddDbContext<DocktorDbContext>(options =>
            //    options.UseInMemoryDatabase("InMemoryDb"));

            builder.Services.AddDbContext<AppointmentBookingDbContext>(options =>
                options.UseInMemoryDatabase("AppointmentBookingDb"));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Module 1: Doctor Availability Module
            builder.Services.AddControllers().AddApplicationPart(typeof(DoctorAvailability.API.AssemblyReference).Assembly);

            //builder.Services.AddScoped<ITimeSlotRepo, TimeSlotRepo>();
            //builder.Services.AddScoped<IDoctorAvailabilityBusiness, DoctorAvailabilityBusiness>();
            #endregion

            #region Module 2: AppointmentBooking Module
            builder.Services.AddControllers().AddApplicationPart(typeof(AppointmentBooking.API.AssemblyReference).Assembly);

            builder.Services.AddScoped<IBookingRepo, BookingRepo>();
            builder.Services.AddScoped<IAppointmentBookingService, AppointmentBookingService>();
            #endregion

            builder.Services.AddControllers().AddApplicationPart(typeof(AppointmentConfirmation.API.AssemblyReference).Assembly);

            #region Module 4: Doctor Availability Module
            //builder.Services.AddControllers().AddApplicationPart(typeof(DoctorAppointmentManagement.API.AssemblyReference).Assembly);

            //builder.Services.AddScoped<SlotService>();
            //builder.Services.AddScoped<AppointmentService>();
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
