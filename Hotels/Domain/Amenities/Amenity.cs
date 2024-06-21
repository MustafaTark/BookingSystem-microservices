using Hotels.Domain.RoomTypes;
using Hotels.Domain.SeedWork;
using Hotels.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Amenities
{
	public class Amenity : Aggregate<AmenityId>
	{
		public string Name { get; private set; } = default!;
		public string ImageUrl { get; private set; } = default!;
		public static Amenity Create(string name, string imageUrl)
		{
			var amenity = new Amenity
			{
				Name = name,
				ImageUrl = imageUrl,
				CreatedAt = DateTime.UtcNow,

			};
			return amenity;
		}
		public void Update(string name, string imageUrl)
		{
			Name = name;
			ImageUrl = imageUrl;
		}
	}
}
