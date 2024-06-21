using Hotels.Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Hotels.Queries.GetHotelById
{
	public record GetHotelsByIdQuery(Guid Id) :IRequest<HotelDto>;
}
