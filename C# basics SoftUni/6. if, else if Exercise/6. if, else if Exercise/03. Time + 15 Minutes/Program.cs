using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min += 15;

            if (min >= 60)
            {
                min -= 60;
                hour++;
            }
            if (hour >= 24)
            {
                hour -= 24;
            }
            Console.WriteLine($"{hour}:{min:d2}");
        }
    }
}
