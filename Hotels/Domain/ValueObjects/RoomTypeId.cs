using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.ValueObjects
{
	public record RoomTypeId
	{
		public Guid Value { get; }
		private RoomTypeId(Guid value) => Value = value;
		public static RoomTypeId Of(Guid value)
		{
			ArgumentNullException.ThrowIfNull(value);
			if (value == Guid.Empty)
			{
				throw new ArgumentNullException();
			}

			return new RoomTypeId(value);
		}
	}
}
