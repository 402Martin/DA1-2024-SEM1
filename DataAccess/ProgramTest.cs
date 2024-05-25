using DataAccess;
using DataAccess.Repositories;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BuissnessLogic.tests;

public class ProgramTest
{
    private SqliteConnection _inMemorySqlite;
    public readonly ServiceProvider serviceProvider;
    public ProgramTest()
    {
        _inMemorySqlite = new SqliteConnection("Data Source=:memory:");
        _inMemorySqlite.Open();
        var services = new ServiceCollection();
        services.AddDbContextFactory<Context>(options =>
            options.UseSqlite(_inMemorySqlite));
        services.AddScoped<UserRepository>();
        serviceProvider = services.BuildServiceProvider();

    }
}