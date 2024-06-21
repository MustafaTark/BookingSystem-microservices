using Hotels.Domain.Hotels.Rules;
using Hotels.Domain.RoomTypes;
using Hotels.Domain.SeedWork;
using Hotels.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Hotels
{
    public class Hotel : Aggregate<HotelId>
	{
		private readonly List<RoomTypeHotel> _roomTypeHotels = new();
		public IReadOnlyList<RoomTypeHotel> RoomTypeHotels => _roomTypeHotels.AsReadOnly();
		public Address Address { get; private set; } = default!;
		public string Name { get; private set; } = default!;
		public string Description { get; private set; } = default!;
		public int StarsCount { get; private set; } = default!;
		public static Hotel Create(Address address , string name, string description, int starsCount) { 
			var hotel = new Hotel
			{
				Address = address,
				Name = name,
				Description = description,
				StarsCount = starsCount,
				CreatedAt = DateTime.UtcNow,
				
			};
			if (hotel.StarsCount > 7)
				throw new BusinessRuleValidationException(new HotelStarsCountShouldBeNotMoreThan7Stars());
			return hotel;
		}
		public void Update(Address address , string name, string description, int starsCount)
		{
			Address = address;
			Name = name;
			Description = description;
			StarsCount = starsCount;
			LastModified = DateTime.UtcNow;
			if (StarsCount > 7)
				throw new BusinessRuleValidationException(new HotelStarsCountShouldBeNotMoreThan7Stars());
		}
		public void AddRoomType(RoomTypeHotel roomType)
		{
			_roomTypeHotels.Add(roomType);
		}

	}
}
