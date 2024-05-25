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

    public User Add(User u)
    {
        return this._userRepository.Add(u);
    }

}
