using Hotels.Domain.Hotels.Rules;
using Hotels.Domain.Hotels;
using Hotels.Domain.SeedWork;
using Hotels.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.RoomTypes
{
	public class RoomType : Aggregate<RoomTypeId>
	{
		private readonly List<RoomTypeAmenity> _roomTypeAmenities = new();
		public IReadOnlyList<RoomTypeAmenity> RoomTypeAmenities => _roomTypeAmenities.AsReadOnly();
		public string Name { get; private set; } = default!;
		public string Description { get; private set; } = default!;
		public static RoomType Create( string name, string description)
		{
			var roomType = new RoomType
			{
				Name = name,
				Description = description,
				CreatedAt = DateTime.UtcNow,

			};
			return roomType;
		}
		public void Update(string name, string description)
		{
			Name = name;
			Description = description;
		}
		public void AddRoomTypeAmenity(RoomTypeAmenity roomTypeAmenity)
		{
			_roomTypeAmenities.Add(roomTypeAmenity);
		}
	}
}
