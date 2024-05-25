using Domain;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Repositories;

public class UserRepository
{
    private readonly IDbContextFactory<Context> _contextFactory;

    public UserRepository(IDbContextFactory<Context> context)
    {
        _contextFactory = context;
    }

    public User Add(User p)
    {
        using var context = _contextFactory.CreateDbContext();
        var user = context.Users.Add(p);
        context.SaveChanges();
        return user.Entity;
    }
}