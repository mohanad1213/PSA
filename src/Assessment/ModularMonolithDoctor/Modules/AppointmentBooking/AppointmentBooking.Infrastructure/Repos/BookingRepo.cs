using AppointmentBooking.Domain.Models;
using AppointmentBooking.Domain.RepoAbstraction;
using AppointmentBooking.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooking.Infrastructure.Repos
{
    public class BookingRepo : IBookingRepo
    {
        #region Private && Constructor 
        private readonly AppointmentBookingDbContext _dbCntxt;

        public BookingRepo(
            AppointmentBookingDbContext appointmentBookingDbContext
            )
        {
            this._dbCntxt = appointmentBookingDbContext;
        }
        #endregion

        public List<BookingModel> GetBooking()
        {
            var dbResult = this._dbCntxt.Bookings.ToList();
            var bookingEntities = dbResult.Select(b => BookingModel.Create(
                //b.Id,
                b.SlotId,
                b.PatientId,
                b.PatientName,
                b.ReservedAt
            )).ToList();

            return bookingEntities;
        }
    }
}
