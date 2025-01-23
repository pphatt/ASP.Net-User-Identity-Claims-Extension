using MediatR;
using Microsoft.Extensions.Logging;
using Server.Application.Common.Interfaces.Persistence;
using Server.Domain.Entity.Identity;

namespace Server.Application.Features.IdentityApp.Queries.GetAllUsers;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<AppUsers>>
{
    ILogger<GetAllUsersQueryHandler> _logger;
    IIdentityRepository _repository;

    public GetAllUsersQueryHandler(ILogger<GetAllUsersQueryHandler> logger, IIdentityRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public async Task<List<AppUsers>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Get all user request.");

        return await _repository.GetAllUsers();
    }
}
