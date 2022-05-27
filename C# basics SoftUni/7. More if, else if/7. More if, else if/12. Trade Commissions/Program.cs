using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
            double commision = 0;

            switch (city)
            {
                case "Sofia":
                    if (number >= 0 && number <= 500)
                    {
                        commision = number * 0.05;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (number > 500 && number <= 1000)
                    {
                        commision = number * 0.07;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (number > 1000 && number <= 10000)
                    {
                        commision = number * 0.08;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (number > 10000)
                    {
                        commision = number * 0.12;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }

                    break;
                case "Varna":
                    if (number >= 0 && number <= 500)
                    {
                        commision = number * 0.045;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (number > 500 && number <= 1000)
                    {
                        commision = number * 0.075;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (number > 1000 && number <= 10000)
                    {
                        commision = number * 0.1;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (number > 10000)
                    {
                        commision = number * 0.13;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }

                    break;
                case "Plovdiv":
                    if (number >= 0 && number <= 500)
                    {
                        commision = number * 0.055;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (number > 500 && number <= 1000)
                    {
                        commision = number * 0.08;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (number > 1000 && number <= 10000)
                    {
                        commision = number * 0.12;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else if (number > 10000)
                    {
                        commision = number * 0.145;
                        Console.WriteLine($"{commision:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }

                    break;

                default:
                    Console.WriteLine($"error");
                    break;
            }
        }
    }
}
