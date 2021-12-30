using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Введите целое число от 0 до 500");
            var a = ulong.Parse(Console.ReadLine());
            ulong sumCu = 0;

           for (ulong i = a; i < 500; i++)
            {
                sumCu = sumCu + (i * i * i);
            }
            Console.WriteLine($"Сумма кубов чисел от {a} до 500 равна {sumCu}");
            Console.WriteLine();

            ///Console.WriteLine("Task 2");

            Console.WriteLine("Task 3");
            Console.WriteLine("Введите натуральное число");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Квадраты натуральных чисел не превышающих {n}:");
            int j = 1;
            while (j * j < n)
            {
                Console.Write($"{j * (j++)} ");
            }
            Console.WriteLine();


            Console.WriteLine("Task 4");
            Console.WriteLine("Введите натуральное число");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число от 0 до 8 включительно");
            var k = int.Parse(Console.ReadLine());
            int result = Task4(m, k);
            Console.WriteLine($"Сумма цифр числа {m} не превышающих числа {k}: {result}");
            Console.WriteLine();


            Console.WriteLine("Task 5");
            Console.WriteLine("Введите первое натуральное число");
            var f = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе натуральное число");
            var g = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < (f * g); i++)
            {

                if (i % f == 0 && i % g == 0)
                {
                   if (i != 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            Console.WriteLine();


            //Console.WriteLine("Task 6");
            //Console.WriteLine("Введите количество академических групп");
            //var h = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число студентов в группе");
            //var s = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите количество экзаменов, сдаваемых одним студентом");
            //var b = int.Parse(Console.ReadLine());
            








            Console.ReadKey();
        }
        static int Task4 (int m, int k)
        {
            int n = 0;
            int result = 0;
                do
                {
                    n = m % 10;
                    if(n >= k)
                    {
                        result = result + n;
                    }    
                    m = m / 10;
                }while (m > 0);
            return result;
        }
    }
}
