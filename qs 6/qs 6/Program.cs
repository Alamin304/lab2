using System;

namespace qs_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorials of :");
            String x;
            double l = 1;
            x = Console.ReadLine();
            int z = Convert.ToInt32(x);
            for (int i = 1; i <= z; i++)
            {
                l = l * i;
            }
            Console.WriteLine(l);
        }
    }
}
