using System.Reflection;

namespace AdaptiveWeather.Reflection
{
    public class ReflectionBaseHelper
    {
        private readonly IConfiguration _configuration;
        private static Assembly LoadAssembly(string assemblyPath)
        {
            return Assembly.LoadFrom(assemblyPath);
        }


        public ReflectionBaseHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private static void DisplayAllType(Assembly assembly)
        {

            
            foreach(var type in assembly.GetTypes())
            {
                if(type.Name == "NullableAttribute")
                {
                    continue;
                }
                Console.WriteLine($"Type: {type.Name}");
                Console.WriteLine("===================");
            

                foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    Console.WriteLine($"Method: {method.Name}");
                    if (method.Name == "AddUser")
                    {
                        var instance = Activator.CreateInstance(type);
                        var userDTO = new UserDto();
                        userDTO.Username = "Name";
                        userDTO.Password = "Password";
                        var testo = method.Invoke(instance, new[] { userDTO });
                    }
                }
                Console.WriteLine("===================");
            }



        }

        public void RefGo()
        {
            var assemblyLocation = _configuration.GetSection("AppSettings:DatabaseAssemblyUrl").Value;
            Assembly assembly =  LoadAssembly(assemblyLocation);                              
            DisplayAllType(assembly);
        }

    }
}
