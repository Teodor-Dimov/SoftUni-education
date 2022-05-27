using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double summ = double.Parse(Console.ReadLine());
                sum += summ;

            }
            Console.WriteLine(sum);
        }
    }
}
