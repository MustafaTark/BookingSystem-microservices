using Hotels.Application.Dto;
using Hotels.Domain.Hotels;
using Hotels.Domain.RoomTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Hotels.Queries.GetAllHotels
{
	public class GetAllHotelsQueryHandller : IRequestHandler<GetAllHotelsQuery, IEnumerable<HotelDto>>
	{
		private readonly IHotelsRepository _hotelsRepository;
		public GetAllHotelsQueryHandller(IHotelsRepository hotelsRepository)
		{
			_hotelsRepository = hotelsRepository;
		}

		public async Task<IEnumerable<HotelDto>> Handle(GetAllHotelsQuery request, CancellationToken cancellationToken)
		{
			var hotels = (await _hotelsRepository.FindAll(false)).Select(h=> new HotelDto
			(
				Id : h.Id.Value,
				RoomTypes: new List<RoomTypeHotelDto>(),
				Address : h.Address,
				Name : h.Name,
				Description : h.Description,
				StarsCount : h.StarsCount
			)).ToList();
			return hotels;
		}
	}
}
