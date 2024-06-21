using Booking.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Bookings.Rules
{
    public class StartDateShouldBeSmallerThanEndDate : IBusinessRule
    {
        public string Message => "StartDate Should Be Smaller Than EndDate";
    }
}
