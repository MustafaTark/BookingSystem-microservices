using Booking.Application.Booking.Commands.CreateBooking;
using Booking.Application.Dto;
using Carter;
using Mapster;
using MediatR;

namespace Booking.Endpoints.Booking
{
    public record CreateBookingRequest(CreateBookingDto Book);
    public record CreateBookingResponse(Guid Id);

    public class CreateBooking : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/bookings", async (CreateBookingRequest request, ISender sender) =>
            {
                 var command = new CreateBookingCommand(new  CreateBookingDto(
                     StartDate: request.Book.StartDate,
                     EndDate: request.Book.EndDate,
                     Notes: request.Book.Notes,
                     HotelId: request.Book.HotelId,
                     RoomTypeId: request.Book.RoomTypeId
                    ));

                var result = await sender.Send(command);

                var response = result.Adapt<CreateBookingResponse>();

                return Results.Created($"/bookings/{response.Id}", response);
            })
            .WithName("CreateBooking")
            .Produces<CreateBookingResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Create Order")
            .WithDescription("Create Order");
        }
    }
}
