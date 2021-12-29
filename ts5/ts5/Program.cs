using System;

namespace ts5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на английском языке");

            string engSt = Console.ReadLine();

            string leetSt = FrEngToLeet(engSt);
            Console.WriteLine(leetSt);

            string stOne = "теплоход";
            
            Console.WriteLine(stOne.Substring(7, 1) + stOne.Substring(1, 1) + stOne.Substring(3, 2));            
            Console.WriteLine(stOne.Substring(5, 2) + stOne.Substring(3, 2) + stOne.Substring(7, 1));

            Console.ReadKey();

        }

        static string FrEngToLeet(string engSt)
        {
           
            return engSt.ToLower().Replace('a', '4')
                         .Replace('b', '8')
                         .Replace('c', '(')
                         .Replace("d", "|)")
                         .Replace("e", "3")
                         .Replace("f", "|=")
                         .Replace('g', '6')
                         .Replace("h", " |-|")
                         .Replace('i', '!')
                         .Replace('j', ')')
                         .Replace("k", "|<")
                         .Replace('l', '1')
                         .Replace("m", @"|\/|")
                         .Replace("n", @"|\|")
                         .Replace('o', '0')
                         .Replace("p", "|>")
                         .Replace('q', '9')
                         .Replace("r", "|2")
                         .Replace('s', '5')
                         .Replace('t', '7')
                         .Replace("u", "|_|")
                         .Replace("v", @"\/")
                         .Replace("w", @"\/\/")
                         .Replace("x", "><")
                         .Replace("y", @"'/")
                         .Replace('z', '2');
        }
    }

}
