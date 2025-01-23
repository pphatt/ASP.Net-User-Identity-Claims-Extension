using Server.Domain.Entity.Identity;

namespace Server.Application.Common.Interfaces.Persistence;

public interface IIdentityRepository
{
    Task<List<AppUsers>> GetAllUsers();
}
