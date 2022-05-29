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
                    names.Add(stream.ReadLine());
            }

            names.Sort();

            for (var i = 0; i < names.Count(); i++)
                names[i] = names[i].Substring(0, 1).ToUpper() + names[i].Substring(1);
            
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
