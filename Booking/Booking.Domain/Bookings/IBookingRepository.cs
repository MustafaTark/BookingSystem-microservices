using Booking.Domain.SeedWork;
using Booking.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Bookings
{
    public interface IBookingRepository : IBaseRepository<Book>
    {
    }
}
