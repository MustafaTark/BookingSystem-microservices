﻿using Hotels.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Dto
{
	public record HotelDto
	(
		Guid Id, List<RoomTypeHotelDto> RoomTypes, Address Address , string Name, string Description,int StarsCount 
	);
}
