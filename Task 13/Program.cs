using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            
            using (var stream = new StreamReader("names.txt"))
            {
                while (!stream.EndOfStream)
                {
                    var name = stream.ReadLine();
                    if(!names.Contains(name.Substring(0,1).ToUpper()+name.Substring(1)))
                       names.Add(name.Substring(0, 1).ToUpper() + name.Substring(1));
                }
            }

            names.Sort();

            using (var stream = new StreamWriter("result.txt", true))
            {
                Console.WriteLine("Обработка данных:");

                foreach(var name in names)
                {
                    stream.WriteLine(name);
                    Console.Write(". ");
                }

                Console.WriteLine("\nОбработка завершена.");
                Console.WriteLine($"Имен в списке: {names.Count()}");
            }

            Console.ReadKey();
        }
    }
}
