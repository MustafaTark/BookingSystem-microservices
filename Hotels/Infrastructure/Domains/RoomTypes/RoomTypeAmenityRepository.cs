using Hotels.Domain.RoomTypes;
using Hotels.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Infrastructure.Domains.RoomTypes
{
	public class RoomTypeAmenityRepository : BaseRepository<RoomTypeAmenity>, IRoomTypeAmenityRepository
	{
		public RoomTypeAmenityRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
