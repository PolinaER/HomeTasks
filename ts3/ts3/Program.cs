using System;

namespace ts3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число - значение x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"{FindMod3(x)} = |{ x } +|{ x } +|{ x } + √({ x } + 1)|||");

            Console.ReadKey();
        }

        static double FindMod3(double x)
        {
            return x = Math.Abs(x + Math.Abs(x + Math.Abs(x + Math.Sqrt(x + 1))));
        }
    }
    
}
