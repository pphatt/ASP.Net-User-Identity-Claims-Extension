using Microsoft.EntityFrameworkCore;
using Server.Application.Common.Interfaces.Persistence;
using Server.Domain.Entity.Identity;
using Server.Infrastructure.Persistence;

namespace Server.Infrastructure.Repositories;

public class IdentityRepository : IIdentityRepository
{
    private readonly AppDbContext _dbContext;

    public IdentityRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<AppUsers>> GetAllUsers()
    {
        var users = await _dbContext.Users.ToListAsync();

        return users;
    }
}
