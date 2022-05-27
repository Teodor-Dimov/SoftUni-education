using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fisherman = double.Parse(Console.ReadLine());

            double sum = 0;

            if (season == "Spring")
            {
                sum += 3000;
                if (fisherman <= 6)
                {
                    sum = sum * 0.90;

                }
                else if (fisherman >= 7 && fisherman <= 11)
                {
                    sum = sum * 0.85;
                }
                else
                {
                    sum = sum * 0.75;
                }

                if (fisherman % 2 == 0)
                {
                    sum = sum * 0.95;
                }
                double remain = Math.Abs(budget - sum);
                if (sum <= budget)
                {
                    Console.WriteLine($"Yes! You have {remain:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {remain:f2} leva.");
                }
            }
            else if (season == "Summer")
            {
                sum += 4200;
                if (fisherman <= 6)
                {
                    sum = sum * 0.90;

                }
                else if (fisherman >= 7 && fisherman <= 11)
                {
                    sum = sum * 0.85;
                }
                else
                {
                    sum = sum * 0.75;
                }

                if (fisherman % 2 == 0)
                {
                    sum = sum * 0.95;
                }
                double remain = Math.Abs(budget - sum);
                if (sum <= budget)
                {
                    Console.WriteLine($"Yes! You have {remain:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {remain:f2} leva.");
                }
            }
            else if (season == "Autumn")
            {
                sum += 4200;
                if (fisherman <= 6)
                {
                    sum = sum * 0.90;

                }
                else if (fisherman >= 7 && fisherman <= 11)
                {
                    sum = sum * 0.85;
                }
                else
                {
                    sum = sum * 0.75;
                }

                //if (fisherman % 2 == 0)
                //{
                //   sum = sum * 0.95;
                //}
                double remain = Math.Abs(budget - sum);
                if (sum <= budget)
                {
                    Console.WriteLine($"Yes! You have {remain:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {remain:f2} leva.");
                }
            }



            else if (season == "Winter")
            {
                sum += 2600;
                if (fisherman <= 6)
                {
                    sum = sum * 0.90;

                }
                else if (fisherman >= 7 && fisherman <= 11)
                {
                    sum = sum * 0.85;
                }
                else
                {
                    sum = sum * 0.75;
                }

                if (fisherman % 2 == 0)
                {
                    sum = sum * 0.95;
                }
                double remain = Math.Abs(budget - sum);
                if (sum <= budget)
                {
                    Console.WriteLine($"Yes! You have {remain:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {remain:f2} leva.");
                }
            }
        }
    }
}
