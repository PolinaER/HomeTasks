using System;


namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два натуральных числа от 5 до 20");
            var m = int.Parse(Console.ReadLine());//строчки 
            var n = int.Parse(Console.ReadLine());//столбцы
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
            Console.Write("Введите натуральное число");
            var k = int.Parse(Console.ReadLine());
            Second(natNum);

            Console.ReadKey();
        }
        static void PrintTable(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //static int[][] First (int[,] arr, int k)
        //{

        //  //for (int i = 0; i < arr.GetLength(0); i++)
        //  //  {
        //     var arr2 = new int[arr.GetLength(0)][];
        //    for (int i = 0; i < arr2.Length; i++)
        //    {
        //        arr2[i] = new int[arr.GetLength(1)];
        //        for (int j = 0; j < arr2[i].Length; j++)
        //        {
        //            arr2[i][j] = arr[i, j];
        //        }
        //    }
          
        //    for (int i = 0; i < arr2.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr2.GetLength(1); j++)
        //        {
        //            if (j > k) 
        //                return arr2.IndexOf(j, 0);
        //        }
        //    }
        //}
            
            
            //В случае положительного ответа выведите на консоль значения индексов строки и столбца любого из таких элементов.
            //В противном случае выведите на консоль сообщение об отсутствии такого элемента.
        
        static void Second (int [,] arr)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    int sum = 0;
                    
                }
            }
                //Напишите метод , который для каждого столбца находит среднее арифметическое элементов этого столбца.
            //Выведите на консоль индексы столбцов и значения их среднего арифметического
        }
    }
}
