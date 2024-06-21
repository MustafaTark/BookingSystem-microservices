using FluentValidation;
using Hotels.Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.Hotels.Commands.CreateHotel
{
	public record CreateHotelCommand(CreateHotelDto Hotel)
	: IRequest<CreateHotelResult>;

	public record CreateHotelResult(Guid Id);

	public class CreateHotelCommandValidator : AbstractValidator<CreateHotelCommand>
	{
		public CreateHotelCommandValidator()
		{
			RuleFor(x => x.Hotel.Name).NotEmpty().WithMessage("Name is required");
			RuleFor(x => x.Hotel.Name).NotEmpty().WithMessage("Name is required");
			RuleFor(x => x.Hotel.Description).NotEmpty().WithMessage("Description is required");
			RuleFor(x => x.Hotel.Description).NotNull().WithMessage("Description is required");
			RuleFor(x => x.Hotel.StarsCount).NotEqual(0).WithMessage("StarCount should not be 0");
			RuleFor(x => x.Hotel.StarsCount).GreaterThan(7).WithMessage("StarCount should not be more than 7");
			RuleFor(x => x.Hotel.RoomTypes).Empty().WithMessage("RoomTypes should not be empty");
		}
	}
}
