using Hotels.Domain.Amenities;
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
	public class RoomTypeAmenity :Entity<RoomTypeId>
	{
		public AmenityId AmenityId { get; private set; } = default!;
		public Amenity? Amenity { get; private set; }
		public RoomTypeId? RoomTypeId { get; private set; }
		public RoomType? RoomType { get; private set; }
		public static RoomTypeAmenity Create(AmenityId amenityId)
		{
			var roomTypeAmenity = new RoomTypeAmenity
			{
				AmenityId = amenityId,
				CreatedAt = DateTime.UtcNow,

			};
			return roomTypeAmenity;
		}
	}
}
