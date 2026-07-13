using Application.Apartments.SearchApartments;
using Application.Bookings.GetBooking;
using Application.Bookings.ReserveBooking;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Apartments;

[ApiController]
[Route("api/bookings")]
public sealed class BookingsController : ControllerBase
{
    private readonly ISender sender;

    public BookingsController(ISender sender)
    {
        this.sender = sender;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBooking(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetBookingQuery(id);
        
        var result = await sender.Send(query, cancellationToken);
        
        return result.IsSuccess ? Ok(result) : NotFound(result);
    }

    [HttpPost]
    public async Task<IActionResult> ReserveBooking(
        ReserveBookingRequest request,
        CancellationToken cancellationToken)
    {
        var command = new ReserveBookingCommand(
            request.ApartmentId,
            request.UserId,
            request.StartDate,
            request.EndDate);
        
        var result = await sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }
        
        return CreatedAtAction(nameof(GetBooking), new {id =  result.Value}, result.Value);
    }
}