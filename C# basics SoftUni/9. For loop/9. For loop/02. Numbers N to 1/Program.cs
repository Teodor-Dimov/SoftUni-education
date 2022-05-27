using System;

namespace _02._Numbers_N_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int counter = 1; counter <= 100; counter++)
            //{
            //   Console.WriteLine(counter);
            //}

            //ex2

            double n = double.Parse(Console.ReadLine());

            for (double i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
