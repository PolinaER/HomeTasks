using System;

namespace ts2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3, c = 5;
            int V = a * b * c;
            int SPov = 2 * a * b + 2 * b * c + 2 * a * c;

            Console.WriteLine($"Прямоугольный параллелипипед со сторонами {a}, {b}, {c}  имеет объём: {V} и площадь поверхности: {SPov}");

            Console.ReadKey();
        }
    
    }
}
