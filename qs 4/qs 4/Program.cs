using System;

namespace qs_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    x = x + i;
                }
                else
                {
                    y = y + i;
                }

            }
            Console.WriteLine("Even Sum : " + x);
            Console.WriteLine("Odd Sum :" + y);
        }
    }
}