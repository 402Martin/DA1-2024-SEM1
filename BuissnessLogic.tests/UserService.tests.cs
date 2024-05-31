using BuissnesLogic;
using BuissnesLogic.Dtos;
using DataAccess;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BuissnessLogic.tests;

[TestClass]
public class UserServiceTests
{
    private UserService _userService;

    [TestInitialize]
    public void OnInitilalize()
    {
        var testsContext = new ProgramTest();
        using var scope = testsContext.serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<IDbContextFactory<Context>>().CreateDbContext();
        UserRepository userRepository= scope.ServiceProvider.GetRequiredService<UserRepository>();
        _userService = new UserService(userRepository);

    }

    [TestMethod]
    public void AddSuccessful()
    {
        UserDto user = new UserDto()
        {
            Email = "martin.radovitzky@gmail.com",
            Surname = "martin.radovitzky@gmail.com",
            Name = "martin.radovitzky@gmail.com",
        };
        var userAdded = this._userService.Add(user);
        Assert.AreEqual(user.Email, userAdded.Email);
    }

    [TestMethod]
    public void GetAllSuccessful()
    {
        var userAdded = this._userService.GetAll();
        Assert.AreEqual(0,userAdded.Count);
    }
}