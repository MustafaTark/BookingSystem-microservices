using Booking.Domain.Bookings;
using Booking.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Booking.Commands.UpdateBooking
{
    public class UpdateBookingCommandHandller(IBookingRepository bookingRepository) :
                                   IRequestHandler<UpdateBookingCommand, UpdateBookingResult>
    {
        private readonly IBookingRepository _bookingRepository = bookingRepository;

        public async Task<UpdateBookingResult> Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = await _bookingRepository.Find(b => b.Id.Value == request.model.Id,trackChanges:true);

            booking!.Update(request.model.StartDate,
                            request.model.EndDate,
                            HotelId.Of(request.model.HotelId),
                            RoomTypeId.Of(request.model.RoomTypeId),
                            request.model.Notes);

            _bookingRepository.Update(booking);
           
            await _bookingRepository.SaveAsync(cancellationToken);

            return new UpdateBookingResult(booking.Id.Value);
        }
    }
}
