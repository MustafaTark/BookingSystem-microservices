using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.ValueObjects
{
    public record HotelId 
    {
        public Guid Value { get; private set; }
        private HotelId() { }
        private HotelId(Guid value) => Value = value;
        public static HotelId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new ArgumentNullException();
            }

            return new HotelId(value);
        }
    }
}
