using Hotels.Application.Hotels.Commands.CreateHotel;
using Hotels.Domain.Hotels;
using Hotels.Domain.RoomTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Hotels.Commands.UpdateHotel
{
	public class UpdateHotelCommandHandller(IHotelsRepository hotelRepository) : IRequestHandler<UpdateHotelCommand, UpdateHotelResult>
	{
		private readonly IHotelsRepository _hotelRepository = hotelRepository;

		public async Task<UpdateHotelResult> Handle(UpdateHotelCommand request, CancellationToken cancellationToken)
		{
			var hotel =await _hotelRepository.Find(c=>c.Id.Value == request.Hotel.Id,true);
			hotel.Update(request.Hotel.Address, request.Hotel.Name, request.Hotel.Description, request.Hotel.StarsCount);

			 _hotelRepository.Update(hotel);

			await _hotelRepository.SaveAsync(cancellationToken);

			return new UpdateHotelResult(hotel.Id.Value);
		}
	}
}
