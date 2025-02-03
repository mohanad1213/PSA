using AppointmentBooking.Application.UseCaseServices;
using AppointmentBooking.Application.ServicesAbstraction;
using AppointmentBooking.Domain.RepoAbstraction;
using AppointmentBooking.Infrastructure.Database;
using AppointmentBooking.Infrastructure.Repos;
using Database;
using DoctorAppointmentManagement.API.Core.Application;
using DoctorAvailability.Business;
using DoctorAvailability.Business.Abstraction;
using Microsoft.EntityFrameworkCore;
using In_MemoryDB.DB1;
using DoctorAvailability.Data.Abstraction;
using DoctorAvailability.Data;
using System;
using In_MemoryDB.DB1.Tables;

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

            builder.Services.AddDbContext<InMemoryDB1>(options =>
                options.UseInMemoryDatabase("InMemoryDB1"));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Module 1: Doctor Availability Module
            builder.Services.AddControllers().AddApplicationPart(typeof(DoctorAvailability.API.AssemblyReference).Assembly);

            builder.Services.AddScoped<ITimeSlotRepo, TimeSlotRepo>();
            builder.Services.AddScoped<IDoctorAvailabilityBusiness, DoctorAvailabilityBusiness>();
            #endregion

            #region Module 2: AppointmentBooking Module
            //builder.Services.AddControllers().AddApplicationPart(typeof(AppointmentBooking.API.AssemblyReference).Assembly);

            //builder.Services.AddScoped<IBookingRepo, BookingRepo>();
            //builder.Services.AddScoped<IAppointmentBookingService, AppointmentBookingService>();
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


            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<InMemoryDB1>();
                SeedData(context); // Call to seed data
            }

            app.Run();
        }


        #region  In-MemoryDB:  Seed DB1
        private static void SeedData(InMemoryDB1 context)
        {

            var timeSlots = new List<TimeSlot>();
            for (int i = 1; i <= 10; i++)
            {
                timeSlots.Add(new TimeSlot
                {
                    id = Guid.NewGuid(),
                    time = DateTime.Now.AddHours(i),
                    doctorId = Guid.NewGuid(),
                    doctorName = $"Doctor {i}",
                    isReserved = false,
                    cost = 100 + i * 10
                });

                context.timeSlots.AddRange(timeSlots);
            }


            //context.ToDoLists.AddRange(
            //    new ToDoList { ToDoListId = 1, UserId = 1, Title = "Groceries", Description = "Things to buy", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
            //    new ToDoList { ToDoListId = 2, UserId = 1, Title = "Work", Description = "Work-related tasks", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            //);


            context.SaveChanges(); // Save changes to the in-memory database
        }
        #endregion

    }


}
