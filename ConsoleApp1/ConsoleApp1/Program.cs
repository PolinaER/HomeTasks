using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ENh = Console.ReadLine();
            char[] characters = ENh.ToCharArray();
            characters[2] = '\0';
            string foo = new String(characters);
            Console.WriteLine(foo);
            Console.ReadKey();
        }
    }
}
