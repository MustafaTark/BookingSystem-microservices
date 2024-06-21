using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.ValueObjects
{
	public record AmenityId
	{
		public Guid Value { get; }
		private AmenityId(Guid value) => Value = value;
		public static AmenityId Of(Guid value)
		{
			ArgumentNullException.ThrowIfNull(value);
			if (value == Guid.Empty)
			{
				throw new ArgumentNullException("AmenityId cannot be empty.");
			}

			return new AmenityId(value);
		}
	}
}
