using Hotels.Domain.RoomTypes;
using Hotels.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Infrastructure.Domains.RoomTypes
{
	public class RoomTypeRepository : BaseRepository<RoomType>, IRoomTypeRepository
	{
		public RoomTypeRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
