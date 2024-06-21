using Booking.Application.Dto;
using Booking.Domain.Bookings;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Booking.Queries.GetAllBookingsByUserId
{
    public class GetBookingsByIdQueryHandller(IBookingRepository bookingRepository) : IRequestHandler<GetAllBookingsByUserIdQuery, List<BookingDto>>
    {
        private readonly IBookingRepository _bookingRepository = bookingRepository;

        public async Task<List<BookingDto>> Handle(GetAllBookingsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookingRepository.FindAll(false);

            var result = books.Select(b => new BookingDto(
                 Id:b.Id.Value,
                 StartDate:b.StartDate,
                 EndDate : b.EndDate,
                 Notes:b.Notes,
                 HotelId:b.HotelId.Value,
                 RoomTypeId:b.RoomTypeId.Value
                )).ToList();

            return result;
        }
    }
}
