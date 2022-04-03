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
        public static void AddUser()
        {
            var user = new User();
            user.Username = "Name";
            user.PasswordSalt = "asdf";
            user.PasswordHash = "12344";
            var a = new W2WDBContext();
            a.Users.Add(user);
            a.SaveChanges();
        }
    }
}
