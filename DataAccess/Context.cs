using Domain;

namespace DataAccess;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext{
    public DbSet<User> Users { get; set; }
    public DbSet<Note> Notes { get; set; }
    public Context(DbContextOptions<Context> options) : base(options){
        this.Database.Migrate();
    }
}
