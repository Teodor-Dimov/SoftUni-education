using System;

namespace _6._if__else_if_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int totalSeconds = a + b + c;

            int minutes = 0;
            int seconds = 0;

            if (totalSeconds >= 120)
            {
                minutes = 2;
                seconds = totalSeconds - 120;
            }

            else if (totalSeconds >= 60)
            {
                minutes = 1;
                seconds = totalSeconds - 60;
            }

            else
            {
                seconds = totalSeconds;
            }

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
