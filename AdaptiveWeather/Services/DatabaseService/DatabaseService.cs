﻿using AdaptiveWeather.Reflection;

namespace AdaptiveWeather.Services.DatabaseService
{
    public class DatabaseService : IDatabaseService
    {
        private readonly IConfiguration _configuration;
        private ReflectionBaseHelper reflectionBase;

        public DatabaseService(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            reflectionBase = new ReflectionBaseHelper(_configuration);
        }
        public string CreateUser()
        {
            reflectionBase.RefGo();
            return "";
        }
    }
}
