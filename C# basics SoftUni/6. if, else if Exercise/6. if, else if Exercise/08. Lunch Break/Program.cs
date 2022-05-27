using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            double episodeLenght = double.Parse(Console.ReadLine());
            double breakLenght = double.Parse(Console.ReadLine());

            double lunchBreak = breakLenght * 1 / 8 + breakLenght * 1 / 4;
            double remainingTime = breakLenght - lunchBreak;
            double LEFT = Math.Abs(remainingTime - episodeLenght);
            if (remainingTime - episodeLenght >= 0)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(remainingTime - episodeLenght)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(LEFT)} more minutes.");
            }
        }
    }
}
