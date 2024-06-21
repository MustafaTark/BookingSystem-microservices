using Booking.Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Booking.Queries.GetAllBookingsByUserId
{
    public record GetAllBookingsByUserIdQuery : IRequest<List<BookingDto>>;
}
