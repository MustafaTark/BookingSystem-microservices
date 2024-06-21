using Hotels.Domain.Hotels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Hotels.Commands.CreateHotel
{
	public class CreateHotelCommandHandller(IHotelsRepository hotelRepository) : IRequestHandler<CreateHotelCommand, CreateHotelResult>
	{
		private readonly IHotelsRepository _hotelRepository = hotelRepository;

		public async Task<CreateHotelResult> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
		{
			var hotel = Hotel.Create(request.Hotel.Address, request.Hotel.Name, request.Hotel.Description, request.Hotel.StarsCount);

			var hotelEntity =await _hotelRepository.Create(hotel);

			await _hotelRepository.SaveAsync(cancellationToken);

			return new CreateHotelResult(hotelEntity.Id.Value);
		}
	}
}
