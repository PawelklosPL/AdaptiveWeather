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
                Console.WriteLine($"Type: {type.Name}");
                Console.WriteLine("===================");
                //Fileds
                //foreach(var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                //{
                //    Console.WriteLine($"Filed: {field.Name}");
                //}

                foreach(var method in type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    Console.WriteLine($"Method: {method.Name}");
                }
                Console.WriteLine("===================");
            }



        }

        public static void RefGo()
        {
            Assembly assembly =  LoadAssembly(@"C:\Users\pawel\source\repos\AdaptiveWeather\AdaptiveWeather\bin\Debug\net6.0\Database.dll");
            DisplayAllType(assembly);

        }
    }
}
