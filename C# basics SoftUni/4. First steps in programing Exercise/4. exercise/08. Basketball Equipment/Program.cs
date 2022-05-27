using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double kecove = tax - 0.4 * tax;
            double ekip = kecove - 0.2 * kecove;
            double ball = ekip * 0.25;
            double acc = ball / 5;
            double all = kecove + ekip + ball + acc + tax;
            Console.WriteLine(all);
        }
    }
}
