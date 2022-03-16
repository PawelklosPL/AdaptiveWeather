﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdaptiveWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpPost("get"), Authorize]
        public async Task<ActionResult<String>> GetWeather(String request)
        {
            return Ok("");
        }
    }
}
