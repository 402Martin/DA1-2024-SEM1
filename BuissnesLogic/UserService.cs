using BuissnesLogic.Dtos;
using DataAccess.Repositories;
using Domain;

namespace BuissnesLogic;

public class UserService
{
    private UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
        this._userRepository = userRepository;
    }

    public UserDto Add(UserDto u)
    {
        Console.WriteLine($"adding user {u.Email}");
        var user = new User()
        {
            Surname = u.Surname,
            Name = u.Name,
            Email = u.Email,
        };
        var userDb = this._userRepository.Add(user);
        Console.WriteLine($"Added user {u.Email} with id {userDb.Id}");
        return new UserDto(userDb);

    }

    public List<UserDto> GetAll()
    {
        Console.WriteLine("Getting all users");
        var userList = _userRepository.GetAll();
        Console.WriteLine($"Found {userList.Count}");
        return userList.ConvertAll(u => new UserDto(u));
    }

}
