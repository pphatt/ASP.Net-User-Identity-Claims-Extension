using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Application.Features.IdentityApp.Queries.GetAllUsers;

namespace Server.API.Controllers;

[ApiController]
[Route("/api/identity")]
[Authorize]
public class IdentityController : ControllerBase
{
    IMediator _mediator;

    public IdentityController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("/users")]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _mediator.Send(new GetAllUsersQuery());

        return Ok(users);
    }
}
