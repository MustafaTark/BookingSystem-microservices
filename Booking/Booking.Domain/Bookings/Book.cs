using Booking.Domain.Bookings.Rules;
using Booking.Domain.SeedWork;
using Booking.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Bookings
{
    public class Book : Aggregate<BookingId>
    {
        public string UserId { get; set; } = default!;
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Notes { get; private set; } = default!;
        public HotelId HotelId { get; private set; } = default!;
        public RoomTypeId RoomTypeId { get; private set; } = default!;
        public static Book Create(string userId,DateTime startDate, DateTime endDate,HotelId hotelId ,RoomTypeId roomTypeId ,string notes)
        {
            var booking = new Book
            {
                UserId = userId,    
                StartDate = startDate,
                EndDate = endDate,
                Notes = notes,
                RoomTypeId = roomTypeId,
                HotelId = hotelId
            };
            if(booking.StartDate > booking.EndDate )
                    throw new BusinessRuleValidationException(new StartDateShouldBeSmallerThanEndDate());
            return booking;
        } 
        public void Update(DateTime startDate, DateTime endDate,HotelId hotelId ,RoomTypeId roomTypeId ,string notes)
        {
            StartDate = startDate;
            EndDate = endDate;
            Notes = notes;
            RoomTypeId = roomTypeId;
            HotelId = hotelId;
            if(StartDate > EndDate )
                    throw new BusinessRuleValidationException(new StartDateShouldBeSmallerThanEndDate());
        }
    }
}
