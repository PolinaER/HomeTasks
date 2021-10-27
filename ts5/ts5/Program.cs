using System;

namespace ts5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на английском языке");

            string EngSt = Console.ReadLine();

            string LeerSt = FrEngToLeer(EngSt);


            Console.WriteLine(LeerSt);


            string StOne = "теплоход";
            
            Console.WriteLine(StOne.Substring(0, 5));            
            Console.WriteLine(StOne.Substring(5, 2) + StOne.Substring(3, 2) + StOne.Substring(7, 1));

            Console.ReadKey();

        }

        static string FrEngToLeer(string EngSt)
        {
           
            return EngSt.Replace('a', '4').Replace('A', '4')
                         .Replace('b', '8').Replace('B', '8')
                         .Replace('c', '(').Replace('C', '(')
                         .Replace("d", "|)").Replace("D", "|)")
                         .Replace("e", "3").Replace("e", "3)")
                         .Replace("f", "|=").Replace("F", "|=")
                         .Replace('g', '6').Replace('G', '6')
                         .Replace("h", " |-|").Replace("H", "|-|")
                         .Replace('i', '!').Replace('I', '!')
                         .Replace('j', ')').Replace('J', ')')
                         .Replace("k", "|<").Replace("K", "|<")
                         .Replace('l', '1').Replace('L', '1')
                         .Replace("m", @"|\/|").Replace("M", @"|\/|")
                         .Replace("n", @"|\|").Replace("N", @"|\|")
                         .Replace('o', '0').Replace('O', '0')
                         .Replace("p", "|>").Replace("P", "|>")
                         .Replace('q', '9').Replace('Q', '9')
                         .Replace("r", "|2").Replace("R", "|2")
                         .Replace('s', '5').Replace('S', '5')
                         .Replace('t', '7').Replace('T', '7')
                         .Replace("u", "|_|").Replace("U", "|_|")
                         .Replace("v", @"\/").Replace("V", @"\/")
                         .Replace("w", @"\/\/").Replace("W", @"\/\/")
                         .Replace("x", "><").Replace("X", "><")
                         .Replace("y", @"'/").Replace("Y", @"'/")
                         .Replace('z', '2').Replace('Z', '2');

            

        }
    }

}
