using Hotels.Application.Dto;
using Hotels.Application.Hotels.Commands.CreateHotel;
using Hotels.Application.Hotels.Queries.GetAllHotels;
using Hotels.Application.Hotels.Queries.GetHotelById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Controllers
{
	[Route("api/Hotels")]
	[ApiController]
	public class HotelsController : ControllerBase
	{
		private readonly IMediator _mediator;
		public HotelsController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpPost]
		public async Task<IActionResult> CreateHotel(CreateHotelDto hotelDto)
		{
			var result = await _mediator.Send(new CreateHotelCommand(hotelDto));
			return StatusCode(201, result);
		}
		[HttpGet]
		public async Task<IActionResult> GetAllHotels()
		{
			var result = await _mediator.Send(new GetAllHotelsQuery());
			return StatusCode(200, result);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetHotelById(Guid id)
		{
			var result = await _mediator.Send(new GetHotelsByIdQuery(id));
			return StatusCode(200, result);
		}
	}
}
