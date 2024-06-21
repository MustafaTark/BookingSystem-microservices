using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.ValueObjects
{
	public record RoomTypeAmenityId
	{
		public Guid Value { get; }
		private RoomTypeAmenityId(Guid value) => Value = value;
		public static RoomTypeAmenityId Of(Guid value)
		{
			ArgumentNullException.ThrowIfNull(value);
			if (value == Guid.Empty)
			{
				throw new ArgumentNullException();
			}

			return new RoomTypeAmenityId(value);
		}
	}
}
