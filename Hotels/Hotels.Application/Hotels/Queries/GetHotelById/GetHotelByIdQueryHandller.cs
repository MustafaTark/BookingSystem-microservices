using Hotels.Application.Dto;
using Hotels.Domain.Hotels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Hotels.Queries.GetHotelById
{
	public class GetHotelByIdQueryHandller : IRequestHandler<GetHotelsByIdQuery, HotelDto>
	{
		private readonly IHotelsRepository _hotelsRepository;
		public GetHotelByIdQueryHandller(IHotelsRepository hotelsRepository)
		{
			_hotelsRepository = hotelsRepository;
		}
		public async Task<HotelDto> Handle(GetHotelsByIdQuery request, CancellationToken cancellationToken)
		{
			var hotel = await _hotelsRepository.Find(h => h.Id.Value == request.Id, false);
			var hotelDto = new HotelDto(
									Id:hotel.Id.Value,
									Name:hotel.Name,
									Address:hotel.Address,
									Description:hotel.Description,
									StarsCount:hotel.StarsCount,
									RoomTypes:new List<RoomTypeHotelDto>());
			return hotelDto;
		}
	}
}
