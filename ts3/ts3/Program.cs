using System;

namespace ts3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число - значение x");
            var x = double.Parse(Console.ReadLine());
            FindMod3(x);

            Console.ReadKey();
        }

        static void FindMod3(double x)
        {

            Console.WriteLine(Math.Abs(x + Math.Abs(x + Math.Abs(x + Math.Sqrt(x + 1)))) + 
                                  " = |" + x + "+|" + x + "+|" + x + "+√(" + x + "+1)|||");
        }
    }
    
}
