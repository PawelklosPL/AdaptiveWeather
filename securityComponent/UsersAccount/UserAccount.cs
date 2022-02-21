using System;
using System.Collections.Generic;
using System.Text;

namespace securityComponent.UsersAccount
{
    public class UserAccount : LoginAccountData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int MyProperty { get; set; }
    }

    public class LoginAccountData
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
