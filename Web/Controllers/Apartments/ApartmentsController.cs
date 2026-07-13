using Application.Apartments.SearchApartments;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Apartments;

[ApiController]
[Route("api/apartments")]
public sealed class ApartmentsController : ControllerBase
{
    private readonly ISender sender;

    public ApartmentsController(ISender sender)
    {
        this.sender = sender;
    }
    
    [HttpGet]
    public async Task<IActionResult> SearchApartments(
        DateOnly startDate,
        DateOnly endDate,
        CancellationToken cancellationToken)
    {
        var query = new SearchApartmentsQuery(startDate, endDate);
        
        var result = await sender.Send(query, cancellationToken);
        
        return Ok(result);
    }
}