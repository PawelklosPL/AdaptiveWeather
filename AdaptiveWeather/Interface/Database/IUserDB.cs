namespace AdaptiveWeather.Interface.Database
{
    public interface IUserDB
    {
        public UserDto GetUser(string userLogin);
        UserDto UpdateUser(UserDto user);
        UserDto AddUser(UserDto user);
        bool DeleteUser(string userId);
    }
}
