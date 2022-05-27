using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double videoCard = double.Parse(Console.ReadLine());
            double procesor = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());

            double videoPrice = videoCard * 250;
            double proccesorPrice = videoPrice * 0.35;
            double ramPrice = videoPrice * 0.1;

            double price = videoPrice + proccesorPrice * procesor + ram * ramPrice;

            if (videoCard > procesor)
            {
                price *= 0.85;
            }
            double math = Math.Abs(budget - price);
            if (budget - price >= 0)
            {
                Console.WriteLine($"You have {math:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {math:f2} leva more!");
            }
        }
    }
}
