using System;

namespace Task6
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
            Console.WriteLine("Enter the file of black rook");
            var BlF = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rank of black rook");
            var BlR = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the file of white rook");
            var WhF = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rank of white rook");
            var WhR = int.Parse(Console.ReadLine());

            if (WhF == BlF)
                Console.WriteLine("The posotoion of white rook is dangerous");
            else
               if (WhR == BlR)
                Console.WriteLine("The posotoion of white rook is dangerous");
            else
            {
                Console.WriteLine("The posotoion of white rook is safe");
                
                Console.WriteLine("Enter the file of proposed move of white rook");
                var WhMoveF = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter the rank of proposed move of white rook");
                var WhMoveR = int.Parse(Console.ReadLine());

                Console.WriteLine($"The move is safe for white rook - it is {IsSuppMoveSafe(BlF, BlR, WhMoveF, WhMoveR)}");
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

        static bool IsSuppMoveSafe(char BlF, int BlR, char WhMoveF, int WhMoveR)
        {
            if (BlF == WhMoveF)
                return false;
            else
                if (BlR == WhMoveR)
                    return false;
            else
                return true;
        }
        
    }
}
