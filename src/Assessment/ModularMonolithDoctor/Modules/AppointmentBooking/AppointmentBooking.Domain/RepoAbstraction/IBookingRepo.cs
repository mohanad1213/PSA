using AppointmentBooking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooking.Domain.RepoAbstraction
{
    public interface IBookingRepo
    {
        List<BookingModel> GetBooking();
    }
}
