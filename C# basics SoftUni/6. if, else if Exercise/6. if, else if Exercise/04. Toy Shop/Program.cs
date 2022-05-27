using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzle = 2.6;
            const double doll = 3;
            const double bear = 4.1;
            const double minion = 8.2;
            const double truck = 2;

            double excursionPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzle = int.Parse(Console.ReadLine());
            int numberOfDoll = int.Parse(Console.ReadLine());
            int numberOfBear = int.Parse(Console.ReadLine());
            int numberOfMinion = int.Parse(Console.ReadLine());
            int numberOfTruck = int.Parse(Console.ReadLine());

            int amount = numberOfPuzzle + numberOfDoll + numberOfBear + numberOfMinion + numberOfTruck;

            double totalPrice = numberOfPuzzle * puzzle + numberOfDoll * doll + numberOfBear * bear + numberOfMinion * minion + numberOfTruck * truck;

            if (amount >= 50)
            {
                totalPrice *= 0.75;
            }


            double rent = totalPrice * 0.10;
            double difference = Math.Abs(rent + excursionPrice - totalPrice);
            if (totalPrice >= rent + excursionPrice)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
        }
    }
}
