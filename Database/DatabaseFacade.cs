

using AdaptiveWeather;
using AdaptiveWeather.Interface;
using Database.BusinessLogic;

namespace Database
{
    public class DatabaseFacade : IDatabase
    {
        public UserFromInterface AddUser(UserFromInterface user)
        {
            DatabaseBusinessLogic.AddUser(user);
            throw new NotImplementedException();
        }

        public void AddWeather()
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        public void EditWeather()
        {
            throw new NotImplementedException();
        }

        public void GetUser(string userLogin)
        {
            throw new NotImplementedException();
        }

        public void GetWeather()
        {
            throw new NotImplementedException();
        }

        public void RemoveWeather()
        {
            throw new NotImplementedException();
        }

        public UserFromInterface UpdateUser(UserFromInterface user)
        {
            throw new NotImplementedException();
        }

        public void UpdateWeather()
        {
            throw new NotImplementedException();
        }
    }
}