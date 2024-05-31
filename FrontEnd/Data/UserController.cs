using BuissnesLogic;
using BuissnesLogic.Dtos;
using Domain;

namespace FrontEnd.Data;

public class UserController
{
    private UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    public UserDto Add(UserDto u)
    {
        return this._userService.Add(u);
    }
    
    public List<UserDto> GetAll()
    {
        return this._userService.GetAll();
    }
}