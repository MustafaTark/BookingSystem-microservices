using Booking.Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Booking.Commands.UpdateBooking
{
    public record UpdateBookingCommand(UpdateBookingDto model) : IRequest<UpdateBookingResult>;

    public record UpdateBookingResult(Guid Id);
}
