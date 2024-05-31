using Domain;

namespace DataAccess;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext{
    public DbSet<User> Users { get; set; }
    public DbSet<Note> Notes { get; set; }
    public Context(DbContextOptions<Context> options) : base(options)
    {
        var relationalOptionsExtension = options.Extensions
            .OfType<Microsoft.EntityFrameworkCore.Infrastructure.RelationalOptionsExtension>()
            .FirstOrDefault();
        
        var databaseType = relationalOptionsExtension?.Connection?.GetType().Name;
        if( databaseType != null && databaseType.Contains("Sqlite"))
            this.Database.EnsureCreated();
        else
            this.Database.Migrate();
    }
}
