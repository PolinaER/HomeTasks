using System;

namespace ts2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину, высоту и ширину прямоугольного параллелипипеда");
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            double V = a * b * c;
            double SPov = 2 * a * b + 2 * b * c + 2 * a * c;

            Console.WriteLine($"Прямоугольный параллелипипед со сторонами {a}, {b}, {c}  имеет объём: {V} и площадь поверхности: {SPov}");

            Console.ReadKey();
        }
    
    }
}
