using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Domain.Bookings;
using Booking.Infrastructure.Data;
namespace Booking.Infrastructure.Domain.Booking
{
    public class BookingRepository(ApplicationDbContext context) : BaseRepository<Book>(context) , IBookingRepository
    {
    }
}
