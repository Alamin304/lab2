using System;

namespace _2nd_lab
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = 100;
            Console.WriteLine("Even Numbers from 1 to " + n + "  are: ");
            for (int i = 1; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
