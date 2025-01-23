using MediatR;
using Server.Domain.Entity.Identity;

namespace Server.Application.Features.IdentityApp.Queries.GetAllUsers;

public class GetAllUsersQuery : IRequest<List<AppUsers>>
{
}
