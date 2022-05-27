using System;

namespace _03._Numbers_1_to_N_with_Step_3
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

            //double n = double.Parse(Console.ReadLine());

            //            for (double i = n; i >= 1; i--)
            ///          {
            //           Console.WriteLine(i);
            //     }


            double n = double.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
