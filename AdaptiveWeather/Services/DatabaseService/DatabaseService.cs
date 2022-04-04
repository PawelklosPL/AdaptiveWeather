using AdaptiveWeather.Reflection;

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

            var userDTO = new AdaptiveWeather.User();
            userDTO.Username = "NowePanie";
            var pbjectTOAdd =   userDTO;

            reflectionBase.RefGo("AppSettings:DatabaseAssemblyUrl", "AddUser", pbjectTOAdd);
            return "";
        }
    }
}
