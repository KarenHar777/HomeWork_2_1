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
            int b = 21;
            int c = 352;
            int d = 16;

            

            int[] numbers = new int[] { a, b, c, d };
            //31
            Console.WriteLine(numbers.Max());
            //32
            Console.WriteLine(numbers.Min());
            //33
            Console.WriteLine(numbers.Contains(1));
            //34
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
            //35
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
            Console.Write("39: ");
            
            ////dasavorel yst achman kargi-------------------------------------------------------------------
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            //40
            Console.Write("40: ");

            
            ////dasavorel yst nvazman kargi-------------------------------------------------------------------
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            //151
            int r =0;
            int n = 7;
            for (int i = 0;i< numbers.Length;i++)
            {

                if (numbers[i]%n == 0)
                {
                    r += numbers[i];
                }
            }
            Console.WriteLine("151: " + r);

            //152
            int r1 = 1;
            int n1 = 7;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % n1 == 0)
                {
                    r1 *= numbers[i];
                }
            }
            Console.WriteLine("152: " + r1);

            //153
            int r2 = 0;
            int n2 = 7;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % n2 == 2)
                {
                    r2 += numbers[i];
                }
            }
            Console.WriteLine("153: " + r2);

            //154
            int r3 = 1;
            int n3 = 7;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % n3 == 2)
                {
                    r3 *= numbers[i];
                }
            }
            Console.WriteLine("154: " + r3);

            //155
            int res1 = 0;
            for (int i = 10; i < 100; i++)
            {
                if (i%3 == 0 && i%5==0)
                {
                    res1 +=i;
                }
            }
            Console.WriteLine("155: " + res1);

            //156
            long res2 = 1;
            for (long i = 10; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    res2 *= i;
                }
            }
            Console.WriteLine("156: " + res2);

            //157
            int res3 = 0;
            for (int i = 100; i < 1000; i++)
            {
                if (i % 5 != 0)
                {
                    res3 += i;
                }
            }
            Console.WriteLine("157: " + res3);

            //158
            long res4 = 1;
            for (long i = 10; i < 100; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    res4 *= i;
                }
            }
            Console.WriteLine("158: " + res4);

            //159
            long res5 = 1;
            for (long i = 100; i < 1000; i++)
            {
                if (i % 3 == 1 && i % 4 == 2)
                {
                    res5 *= i;
                }
            }
            Console.WriteLine("159: " + res5); // pastoren ytenc tiv chka

            //160
            int res6 = 1;
            int h ;
            for (int i = 100; i < 1000; i++)
            {
                if (i * 16 == Math.Sqrt(i))
                {
                    Console.WriteLine("h:" +  i);
                }
            }
            Console.WriteLine("160: " + res6);

            Console.ReadLine();
        }
    }
}
