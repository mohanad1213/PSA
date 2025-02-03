using AppointmentBooking.Domain.Models;
using AppointmentBooking.Domain.RepoAbstraction;
using AppointmentBooking.Infrastructure.Database;
using In_MemoryDB.DB1;
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
        private readonly InMemoryDB1 _inMemoryDB1;

        public BookingRepo(
            InMemoryDB1 inMemoryDB1
            )
        {
            this._inMemoryDB1 = inMemoryDB1;
        }
        #endregion

        public void GetBooking()
        {
            //var dbResult = this._inMemoryDB1.ToList();
            //var bookingEntities = dbResult.Select(b => BookingModel.Create(
            //    //b.Id,
            //    b.SlotId,
            //    b.PatientId,
            //    b.PatientName,
            //    b.ReservedAt
            //)).ToList();

            //return bookingEntities;
        }
    }
}
