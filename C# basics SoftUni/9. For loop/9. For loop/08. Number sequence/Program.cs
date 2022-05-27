using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double big = int.MinValue;
            double small = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double summ = double.Parse(Console.ReadLine());
                if (summ > big)
                {
                    big = summ;
                }
                if (summ < small)
                {
                    small = summ;
                }


            }

            Console.WriteLine($"Max number: {big}");
            Console.WriteLine($"Min number: {small}");
        }
    }
}
