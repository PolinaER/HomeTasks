using System;

namespace ts1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ночь, улица, фонарь, аптека...");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ночь, улица, фонарь, аптека,");
            Console.WriteLine("Бессмысленный и тусклый свет.");
            Console.WriteLine("Живи еще хоть четверть века —");
            Console.WriteLine("Всё будет так. Исхода нет.");
            Console.WriteLine("Умрешь — начнешь опять сначала");
            Console.WriteLine("И повторится всё, как встарь:");
            Console.WriteLine("Ночь, ледяная рябь канала,");
            Console.WriteLine("Аптека, улица, фонарь.");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
