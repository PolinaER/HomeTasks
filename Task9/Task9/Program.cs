using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            var n = int.Parse(Console.ReadLine());
            double[] viceVersa = new double[n];
            for (int i = n - 1; i < viceVersa.Length && i >= 0; i = i - 1)
            {
                Console.Write($"Введите элемент массива номер {i}: ");
                viceVersa[i] = double.Parse(Console.ReadLine());
            }

            PrintArray(viceVersa);
            Console.WriteLine();
            PlusNumtoElArr(viceVersa);
            PrintArray(viceVersa);
            Console.WriteLine($"\nСумма элементов массива делёная на 10, равна: {SummAndModTen(viceVersa)}");
            Console.WriteLine("Массив с переставленными элементами:");
            double[] copy = new double[n];
            Array.Copy(viceVersa, copy, n);
            MoveElPlaces(copy);
            PrintArray(copy);
            Console.ReadLine();
        }
        static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}; ");
        }
        static void PlusNumtoElArr(double[] array)
        {
            Console.Write("Введите целое число: ");
            var k = double.Parse(Console.ReadLine());
            int i;
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = (array[i] + k) / 10;
                }
        }
        static double SummAndModTen(double[] array)
        {
            double summdelten = 0;
            for (int i = 0; i < array.Length; i++)
                summdelten += array[i];
            return summdelten = summdelten / 10;
        }
        static void MoveElPlaces(double[] array)
        {
            double a;
            for (int i = 0; i < array.Length - 1; i++)
            {
                a = array[i];
                array[i] = array[i + 1];
                array[i + 1] = a;
                i++;
            }
            
        }
       

    }


}
