using Booking.Application.Dto;
using Booking.Domain.Bookings;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Booking.Queries.GetBookingById
{
    public class GetBookingsByIdQueryHandller(IBookingRepository bookingRepository) : IRequestHandler<GetBookingByIdQuery, BookingDto>
    {
        private readonly IBookingRepository _bookingRepository = bookingRepository;

        public async Task<BookingDto> Handle(GetBookingByIdQuery request, CancellationToken cancellationToken)
        {
            var book = (await _bookingRepository.FindByCondition(b=>b.Id.Value == request.id ,false)).Select(b => new BookingDto(
                 Id: b.Id.Value,
                 StartDate: b.StartDate,
                 EndDate: b.EndDate,
                 Notes: b.Notes,
                 HotelId: b.HotelId.Value,
                 RoomTypeId: b.RoomTypeId.Value
                )).FirstOrDefault();

            return book!;
        }
    }
}
