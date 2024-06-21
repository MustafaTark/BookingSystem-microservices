using Hotels.Domain.Hotels;
using Hotels.Domain.SeedWork;
using Hotels.Domain.ValueObjects;
using Hotels.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Infrastructure.Domains.Hotels
{
	public class HotelsRepository : BaseRepository<Hotel>, IHotelsRepository
	{
		public HotelsRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
