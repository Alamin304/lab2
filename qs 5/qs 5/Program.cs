using System;

namespace qs_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= x; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(i);
                if (x != 5)
                    x++;
            }
        }
    }
}