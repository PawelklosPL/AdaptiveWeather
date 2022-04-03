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

        private void DisplayAllType(Assembly assembly)
        {
            CallMethodFromAssembly(assembly, "AddUser");



        }

        public void RefGo()
        {
            Assembly assembly = loadAssemblyByName();
            DisplayAllType(assembly);
        }

        private void CallMethodFromAssembly(Assembly assembly, string methodName)
        {
            foreach (var type in assembly.GetTypes())
            {
                if (type.Name == "NullableAttribute")
                {
                    continue;
                }
                foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    Console.WriteLine($"Method: {method.Name}");
                    if (method.Name == methodName)
                    {
                        var instance = Activator.CreateInstance(type);
                        var userDTO = new User();
                        userDTO.Username = "Name";
                        var testo = method.Invoke(instance, new[] { userDTO });
                    }
                }
            }
        }

        private Assembly loadAssemblyByName()
        {
            var assemblyLocation = GetDataBaseAsemblyUrl();
            return LoadAssembly(assemblyLocation);
        }
        private string GetDataBaseAsemblyUrl()
        {
            return _configuration.GetSection("AppSettings:DatabaseAssemblyUrl").Value;
        }


    }
}
