using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 742;
            int b = 200;
            int c = 352;
            int d = 152;

            

            int[] numbers = new int[] { a, b, c, d };

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Contains(1));

            if (a + b == c + d)
            {
                Console.WriteLine(true);
            }
            else if (b + c == d + a)
            {
                Console.WriteLine(true);
            }
            else if (a + c == b + d)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            if (a == b + c + d || b == a + c + d || c == a + b + d || d == a + b + c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            //36
            int resault = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    resault++;
                    
                }
                
            }
            
            if (resault > 3) Console.WriteLine(1);
            else Console.WriteLine(2);
            //37
            if (b - a == c - b && c - b == d-c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            //38
            Console.Write("Erkrachapakan progresia: ");
            if (b / a == c / b && c/b == d/c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            //39
            ////dasavorel yst achman kargi-------------------------------------------------------------------

            //40
            ////dasavorel yst nvazman kargi-------------------------------------------------------------------








            Console.ReadLine();
        }
    }
}
