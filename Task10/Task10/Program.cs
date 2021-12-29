using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два натуральных числа от 5 до 20");
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            int[,] natNum = new int[m, n];
            Random rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int randomNum = rand.Next(0, 99);
                    natNum[i, j] = randomNum;
                }
            }
            PrintTable(natNum);

            Console.Write("Введите натуральное число ");
            var k = int.Parse(Console.ReadLine());
            First(natNum, k);

            Second(natNum);

            Console.ReadKey();
        }
        static void PrintTable(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($"{arr[i, j]} ");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void First(int[,] arr, int k)
        {
            var arr1 = new int[] { k };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j] > k ? $"{arr[i, j]} больше числа {k}" : $"В массиве нет элемента больше числа {k}");
                    break;
                }
                break;
            }
        }

        static void Second(int[,] arr)
        {
            double[] arif = new double[arr.GetLength(1)];
            for (int i = 0, n = 0; i < arr.GetLength(1); i++)
            {
                double summ = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    summ += arr[j, i];
                }
                arif[n] = summ / arr.GetLength(0);
                Console.WriteLine($"Среднее арифметическое столбца {i} равно {arif[n]} ");
                n++;
            }
        }
    
    }
}
