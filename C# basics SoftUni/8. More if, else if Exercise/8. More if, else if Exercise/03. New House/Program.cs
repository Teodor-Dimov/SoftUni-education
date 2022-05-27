using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            double NumOfFlowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            const double priceOfRoses = 5;
            const double priceOfDahlias = 3.8;
            const double priceOfTulips = 2.8;
            const double priceOfNarcissus = 3;
            const double priceOfGladiolus = 2.5;

            double sum = 0;

            if (flower == "Roses")
            {
                sum = priceOfRoses * NumOfFlowers;
                if (NumOfFlowers > 80)
                {
                    sum = sum * 0.9;
                }
                double money = Math.Abs(budget - sum);
                if (sum <= budget)
                {
                    Console.WriteLine($"Hey, you have a great garden with {NumOfFlowers} {flower} and {money:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {money:f2} leva more.");
                }
            }
            if (flower == "Dahlias")
            {
                sum = priceOfDahlias * NumOfFlowers;
                if (NumOfFlowers > 90)
                {
                    sum = sum * 0.85;
                }
                double money = Math.Abs(budget - sum);
                if (sum <= budget)
                {
                    Console.WriteLine($"Hey, you have a great garden with {NumOfFlowers} {flower} and {money:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {money:f2} leva more.");
                }
            }
            if (flower == "Tulips")
            {
                sum = priceOfTulips * NumOfFlowers;
                if (NumOfFlowers > 80)
                {
                    sum = sum * 0.85;
                }
                double money = Math.Abs(budget - sum);
                if (sum <= budget)
                {
                    Console.WriteLine($"Hey, you have a great garden with {NumOfFlowers} {flower} and {money:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {money:f2} leva more.");
                }
            }
            if (flower == "Narcissus")
            {
                sum = priceOfNarcissus * NumOfFlowers;
                if (NumOfFlowers < 120)
                {
                    sum = sum * 1.15;
                }
                double money = Math.Abs(budget - sum);
                if (sum <= budget)
                {
                    Console.WriteLine($"Hey, you have a great garden with {NumOfFlowers} {flower} and {money:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {money:f2} leva more.");
                }
            }
            if (flower == "Gladiolus")
            {
                sum = priceOfGladiolus * NumOfFlowers;
                if (NumOfFlowers < 80)
                {
                    sum = sum * 1.2;
                }
                double money = Math.Abs(budget - sum);
                if (sum <= budget)
                {
                    Console.WriteLine($"Hey, you have a great garden with {NumOfFlowers} {flower} and {money:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {money:f2} leva more.");
                }
            }
        }
    }
}
