using Hotels.Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Hotels.Queries.GetAllHotels
{
	public record GetAllHotelsQuery() : IRequest<IEnumerable<HotelDto>>;
}
