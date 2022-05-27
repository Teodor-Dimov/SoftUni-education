using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string weather = Console.ReadLine();

            switch (weather)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        budget *= 0.3;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {budget:f2}");
                    }
                    else if (budget <= 1000)
                    {
                        budget *= 0.4;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine($"Camp - {budget:f2}");
                    }
                    if (budget > 1000)
                    {
                        budget *= 0.9;
                        Console.WriteLine($"Somewhere in Europe");
                        Console.WriteLine($"Hotel - {budget:f2}");
                    }

                    break;


                case "winter":
                    if (budget <= 100)
                    {
                        budget *= 0.7;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {budget:f2}");
                    }
                    else if (budget <= 1000)
                    {
                        budget *= 0.8;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {budget:f2}");
                    }
                    if (budget > 1000)
                    {
                        budget *= 0.9;
                        Console.WriteLine($"Somewhere in Europe");
                        Console.WriteLine($"Hotel - {budget:f2}");
                    }

                    break;


                default:
                    break;
            }
        }
    }
}
