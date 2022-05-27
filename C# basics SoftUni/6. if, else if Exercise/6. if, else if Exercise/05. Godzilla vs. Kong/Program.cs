using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double stuntman = double.Parse(Console.ReadLine());
            double priceForOneClothes = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.1;
            double totalPriceForClothes = stuntman * priceForOneClothes;
            if (stuntman > 150)
            {
                totalPriceForClothes *= 0.9;

            }
            double totalMoney = decorPrice + totalPriceForClothes;
            if (totalMoney > budget)
            {
                double neededMoney = totalMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double left = budget - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {left:f2} leva left.");
            }
        }
    }
}
