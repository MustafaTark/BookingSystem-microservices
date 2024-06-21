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
	public class RoomTypeHotel : Entity<RoomTypeHotelId>
	{
		public HotelId HotelId { get; set; } = default!;
		public Hotel? Hotel { get; private set; }
		public RoomTypeId RoomTypeId { get; private set; } = default!;
		public RoomType? RoomType { get; private set; }
		public static RoomTypeHotel Create(RoomTypeId roomTypeId)
		{
			var roomTypeHotel = new RoomTypeHotel
			{
				RoomTypeId = roomTypeId,
				CreatedAt = DateTime.UtcNow,

			};
			return roomTypeHotel;
		}
	}
}
