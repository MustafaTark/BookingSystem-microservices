using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.ValueObjects
{
    public record BookingId
    {
        public Guid Value { get; private set; }
        private BookingId() { }
        private BookingId(Guid value) => Value = value;
        public static BookingId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new ArgumentNullException();
            }

            return new BookingId(value);
        }
    }
}
