using Booking.Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Booking.Commands.CreateBooking
{
    public record CreateBookingCommand(CreateBookingDto model) : IRequest<CreateBookingResult>;

    public record CreateBookingResult(Guid Id);
}
