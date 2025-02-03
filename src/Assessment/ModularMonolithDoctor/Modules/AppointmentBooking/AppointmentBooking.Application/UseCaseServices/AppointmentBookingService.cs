using AppointmentBooking.Application.ServicesAbstraction;
using AppointmentBooking.Domain.Models;
using AppointmentBooking.Domain.RepoAbstraction;
using AppointmentConfirmationService.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooking.Application.UseCaseServices
{
    public class AppointmentBookingService : IAppointmentBookingService
    {
        private readonly IBookingRepo _bookingRepo;

        public AppointmentBookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }

        // Use Case 
        public void MyBooking()
        {
            new AppointmentConfirmationServiceGateWay().NotificationGateway(new NotificationMessage()
            {
                PatientName = "Ali",
                DoctorName = "Mohanad",
                Time = DateTime.Now

            });
           // return _bookingRepo.GetBooking();
        }
    }
}
