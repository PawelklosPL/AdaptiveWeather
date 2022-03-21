using AdaptiveWeather;

namespace DatabaseInterface
{
    public interface IUserDB
    {
        public void GetUser(string userLogin);
        UserDto UpdateUser(UserDto user);
        UserDto AddUser(UserDto user);
        bool DeleteUser(string userId);
    }
}
