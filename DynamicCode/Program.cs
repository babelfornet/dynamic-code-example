// See https://aka.ms/new-console-template for more information
using System.Reflection;

namespace DynamicCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new App();
            app.Feature1Demo();
        }

        [Obfuscation(Feature = "msil encryption get password", Exclude = false)]
        internal static string GetPassword(string source)
        {
            Console.WriteLine($"> Get {source} password");

            if (source == "demo")
                return "1234";

            string pwd = File.ReadAllText(source + ".txt");

            Console.WriteLine($">> {source} password: {pwd}");
            return pwd;
        }

        [Obfuscation(Feature = "msil encryption get stream", Exclude = false)]
        internal static object GetSourceStream(string source)
        {
            Console.WriteLine($"> Get {source} stream");

            if (source == "demo")
            {
                string[] sources = { "special", "retail" };
                foreach (var src in sources)
                {
                    if (File.Exists($"{src}.txt"))
                    {
                        Console.WriteLine($">> Switch to {src}");
                        return src;
                    }
                }

                return null;
            }
            
            // External sources
            if (File.Exists(source + ".eil"))
            {
                Console.WriteLine($">>> Read {source} stream");
                return File.OpenRead(source + ".eil");
            }

            return null;
        }
    }
}
