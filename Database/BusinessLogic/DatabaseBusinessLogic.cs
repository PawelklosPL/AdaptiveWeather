using Database.Data;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.BusinessLogic
{
    static class DatabaseBusinessLogic
    {
        public static void AddUser(AdaptiveWeather.UserFromInterface user)
        {
            var userDB = new User();
            userDB.Username = user.Username;
            userDB.PasswordSalt = "1234";
            userDB.PasswordHash = "4321";
            var a = new W2WDBContext();
            a.Users.Add(userDB);
            a.SaveChanges();
        }
    }
}
