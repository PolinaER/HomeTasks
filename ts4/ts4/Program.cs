using System;

namespace ts4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;

            x = SqFr(2, 3) + SqFr(3, 5) + SqFr(5, 7);



            Console.WriteLine($"Значание выражения равно: {x.ToString("F" + 3)}");





            Console.ReadKey();
        }
        static double SqFr(double number1, double number2)
        {
            return Math.Sqrt((number1 + Math.Pow(Math.E, -number1)) / number2);
        }
    }
}
