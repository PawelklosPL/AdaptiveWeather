using AdaptiveWeather;

namespace DatabaseInterface
{
    public interface IUserDB
    {
        public void GetUser(string userLogin);
        UserFromInterface UpdateUser(UserFromInterface user);
        UserFromInterface AddUser(UserFromInterface user);
        bool DeleteUser(string userId);
    }
}
