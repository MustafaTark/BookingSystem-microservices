using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.ValueObjects
{
	public record RoomTypeHotelId
	{
		public Guid Value { get; }
		private RoomTypeHotelId(Guid value) => Value = value;
		public static RoomTypeHotelId Of(Guid value)
		{
			ArgumentNullException.ThrowIfNull(value);
			if (value == Guid.Empty)
			{
				throw new ArgumentNullException();
			}

			return new RoomTypeHotelId(value);
		}
	}
}
