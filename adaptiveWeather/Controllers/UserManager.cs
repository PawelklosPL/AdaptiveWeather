using Microsoft.AspNetCore.Mvc;
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


        private readonly ILogger<WeatherForecastController> _logger;

        public UserManager(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [Route("LogIn")]
        public UserAccount LogIn()
        {
            return new UserAccount();
        }

        [HttpGet]
        public UserAccount LogOff()
        {
            return new UserAccount();
        }
    }
}
