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

        public void RefGo(string reflectionAssemblyName, string methodName, object paramiters)
        {
            Assembly assembly = loadAssemblyByName(reflectionAssemblyName);
            CallMethodFromAssembly(assembly, methodName, paramiters);
        }

        private void CallMethodFromAssembly(Assembly assembly, string methodName, object paramiters)
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
                        var a = paramiters as AdaptiveWeather.User;
                        var testo = method.Invoke(instance, new[] { a });
                    }
                }
            }
        }

        private Assembly loadAssemblyByName(string reflectionAssemblyName)
        {
            var assemblyLocation = GetDataBaseAsemblyUrl(reflectionAssemblyName);
            return LoadAssembly(assemblyLocation);
        }
        private string GetDataBaseAsemblyUrl(string reflectionAssemblyName)
        {
            return _configuration.GetSection(reflectionAssemblyName).Value;
        }

        //"AppSettings:DatabaseAssemblyUrl"
    }
}
