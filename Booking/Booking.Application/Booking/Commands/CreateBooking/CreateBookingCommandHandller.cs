using Booking.Domain.Bookings;
using Booking.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Booking.Commands.CreateBooking
{
    public class CreateBookingCommandHandller(IBookingRepository bookingRepository) :
                                   IRequestHandler<CreateBookingCommand, CreateBookingResult>
    {
        private readonly IBookingRepository _bookingRepository = bookingRepository;

        public async Task<CreateBookingResult> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = Book.Create( "",
                                      request.model.StartDate,
                                      request.model.EndDate,
                                      HotelId.Of(request.model.HotelId),
                                      RoomTypeId.Of(request.model.RoomTypeId),
                                      request.model.Notes);

            var result = await _bookingRepository.Create(booking);

            await _bookingRepository.SaveAsync(cancellationToken);

            return new CreateBookingResult(result.Id.Value);
        }
    }
}
