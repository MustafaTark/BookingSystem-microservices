using Hotels.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Hotels.Rules
{
	public class HotelStarsCountShouldBeNotMoreThan7Stars : IBusinessRule
	{
		public string Message => "Hotel Stars Count Should Be Not More Than 7 Stars";
	}
}
