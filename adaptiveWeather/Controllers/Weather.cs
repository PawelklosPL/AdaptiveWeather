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
    public class Weather : ControllerBase
    {


        private readonly ILogger<Weather> _logger;

        public Weather(ILogger<Weather> logger)
        {
            _logger = logger;
        }

        [Route("GetUnLoginWeather")]
        public UserAccount LogIn()
        {
            throw new NotImplementedException();
        }

        [Route("GetLoginWeather")]
        public UserAccount LogOff()
        {
            throw new NotImplementedException();
        }
    }
}
