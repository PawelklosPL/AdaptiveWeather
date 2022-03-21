using System.Reflection;

namespace AdaptiveWeather.Reflection
{
    public static class ReflectionBase
    {
        private static Assembly LoadAssembly(string assemblyPath)
        {
            return Assembly.LoadFrom(assemblyPath);
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
                //Fileds
                //foreach(var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                //{
                //    Console.WriteLine($"Filed: {field.Name}");
                //}

                

                //Console.WriteLine($"Method: {method.Name}");
                //if (method.Name == "AddUser")
                //{
                //    var userDTO = new UserDto();
                //    userDTO.Username = "Name";
                //    userDTO.Password = "Password";
                //    method.Invoke(instance, new[] { userDTO });
                //}

                foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    Console.WriteLine($"Method: {method.Name}");
                    if (method.Name == "AddUser")
                    {
                        var instance = Activator.CreateInstance(type);
                        var userDTO = new UserDto();
                        userDTO.Username = "Name";
                        userDTO.Password = "Password";
                        method.Invoke(instance, new[] { userDTO });
                    }
                }
                Console.WriteLine("===================");
            }



        }

        public static void RefGo()
        {
            Assembly assembly =  LoadAssembly(@"C:\Users\pawel\source\repos\AdaptiveWeather\Database\bin\Debug\net6.0\Database.dll");                              
            DisplayAllType(assembly);

        }
    }
}
