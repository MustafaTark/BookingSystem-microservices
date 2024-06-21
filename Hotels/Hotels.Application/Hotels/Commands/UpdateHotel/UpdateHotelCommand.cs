using FluentValidation;
using Hotels.Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Hotels.Commands.UpdateHotel
{
	public record UpdateHotelCommand(HotelDto Hotel)
	: IRequest<UpdateHotelResult>;

	public record UpdateHotelResult(Guid Id);

	public class UpdateHotelCommandValidator : AbstractValidator<UpdateHotelCommand>
	{
		public UpdateHotelCommandValidator()
		{
			RuleFor(x => x.Hotel.Name).NotEmpty().WithMessage("Name is required");
			RuleFor(x => x.Hotel.Name).NotNull().WithMessage("Name is required");
			RuleFor(x => x.Hotel.Description).NotEmpty().WithMessage("Description is required");
			RuleFor(x => x.Hotel.Description).NotNull().WithMessage("Description is required");
			RuleFor(x => x.Hotel.StarsCount).NotEqual(0).WithMessage("StarCount should not be 0");
			RuleFor(x => x.Hotel.StarsCount).GreaterThan(7).WithMessage("StarCount should not be more than 7");
			RuleFor(x => x.Hotel.RoomTypes).Empty().WithMessage("RoomTypes should not be empty");
		}
	}
}
