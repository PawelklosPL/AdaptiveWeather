using AdaptiveWeather;

namespace DatabaseInterface
{
    public interface IUserDB
    {
        public void GetUser(string userLogin);
        User UpdateUser(User user);
        User AddUser(User user);
        bool DeleteUser(string userId);
    }
}
