using System;

namespace DemoNetCoreApp1
{
    class Program
    {
        static void display(int n)
        {
            if (n == 0)
                return;
            else
            {
                Console.WriteLine(n);
                display(n - 1);
            }

        }
        static int sumNoneTail(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + sumNoneTail(n - 1);
        }
        static int sumTail(int n, int acc)
        {
            if (n == 0)
                return acc;
            else
            {
                return sumTail(n - 1, n + acc);
            }
        }
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 4;
            //Console.WriteLine(a+b);
            //display(5);
            //Console.WriteLine(sum(5));
            Console.WriteLine(sumTail(5,0));
        }
    }
}
//899;
//5 + sum(4) 
//5+ 4 + sum(3)
//5 + 4+ sum(2)...=> 5 + 4 + 3 + 2 + 1 + 0
