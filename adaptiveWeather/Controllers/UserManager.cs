﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using securityComponent.UsersAccount;

namespace adaptiveWeather.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserManager : ControllerBase
    {


        private readonly ILogger<UserManager> _logger;

        public UserManager(ILogger<UserManager> logger)
        {
            _logger = logger;
        }

        [Route("LogIn")]
        public UserAccount LogIn()
        {
            throw new NotImplementedException();
        }

        [Route("LogOff")]
        public UserAccount LogOff()
        {
            throw new NotImplementedException();
        }
    }
}
