using System;

namespace Task__6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Task6 6.1");
            Console.WriteLine("Enter three inteder numbers");
            var k = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The statement numbers {k}, {m}, {n} are multiple of three is {NumbDel3(k, m, n)}");


            Console.WriteLine("Task6 6.2");
            Console.WriteLine("Enter coordinate х");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate у");
            var y = double.Parse(Console.ReadLine());
            Console.WriteLine($"The statement a point {x};{y} is in this area is {IsPointInArea(x, y)}");


            Console.WriteLine("Task6 6.3");
            Console.WriteLine("Enter the position of black rook");
            var blPos = Console.ReadLine();

            Console.WriteLine("Enter the position of white rook");
            var whPos = Console.ReadLine();
            
            int bF, bR, wF, wR;
            GetCoordinates(blPos, out bF, out bR);
            GetCoordinates(whPos, out wF, out wR);

            if (bF == wF)
            {
                if (bR == wR)
                    Console.WriteLine("The positions are the same");
                else
                    Console.WriteLine("The posotion is dangerous");
            }
            else
            {
                Console.WriteLine("The posotion is safe");
                Console.WriteLine("Enter the position of proposed move of white rook");
                var moveWh = Console.ReadLine();
                Console.WriteLine($"The proposed move of white rook is safe - {IsSuppMoveSafe(moveWh, blPos)}");
            }
                     
            Console.ReadKey();
        }

        static bool NumbDel3(int k, int m, int n)
        {
            if (k % 3 == 0)
            {
                if (m % 3 == 0)
                {
                    if (n % 3 == 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        static bool IsPointInArea(double x, double y)
        {
            if (y < -2)
                return false;
            else
            {
                if (x > -3)
                {
                    if (x < -1)
                        return false;
                    else
                        return true;
                }
                else
                    return true;

            }

        }

        static bool IsSuppMoveSafe(string moveWh, string blPos)
        {
            int bF, bR, mF, mR;
            GetCoordinates(blPos, out bF, out bR);
            GetCoordinates(moveWh, out mF, out mR);

            if (bF == mF)
                return false;
            else
                if (bR == mR)
                return false;
            else
                return true;
        }
       
         static void GetCoordinates(string position, out int row, out int column)
        {
            column = (int)position[1] - 0x31;
            row = (int)position[0] - 0x61;
        }
    }
}

