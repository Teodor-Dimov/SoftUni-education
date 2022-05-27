using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());

            double amount = double.Parse(Console.ReadLine());
            double sumi = amount;
            while (sumi < sum)
            {
                amount = double.Parse(Console.ReadLine());
                sumi += amount;
            }

            Console.WriteLine(sumi);
        }
    }
}
