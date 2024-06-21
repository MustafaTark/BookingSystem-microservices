using Booking.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Dto
{
    public record CreateBookingDto
    (
         DateTime StartDate ,
         DateTime EndDate ,
         string Notes ,
         Guid HotelId ,
         Guid RoomTypeId 
    );
}
