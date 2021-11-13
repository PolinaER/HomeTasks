using System;

namespace Task7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter value x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"The function y({x}) = {CalculFunctVal(x)}");

        }
        static double CalculFunctVal(double x)
        {
           double y;
           if (x > 1)
               return y = Math.Log(x);
           else
             if (x > 0)
                 return y = -Math.Log(x);
             else
                 return y = 0;         
        }   
    }
}
