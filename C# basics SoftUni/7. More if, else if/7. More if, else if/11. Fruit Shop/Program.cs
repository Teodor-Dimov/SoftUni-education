using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string stock = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double price = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (stock == "banana")
                    {
                        price = 2.5;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "apple")
                    {
                        price = 1.2;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "orange")
                    {
                        price = 0.85;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "grapefruit")
                    {
                        price = 1.45;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "kiwi")
                    {
                        price = 2.7;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "pineapple")
                    {
                        price = 5.5;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "grapes")
                    {
                        price = 3.85;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;

                case "Saturday":
                case "Sunday":
                    if (stock == "banana")
                    {
                        price = 2.7;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "apple")
                    {
                        price = 1.25;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "orange")
                    {
                        price = 0.9;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "grapefruit")
                    {
                        price = 1.6;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "kiwi")
                    {
                        price = 3;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "pineapple")
                    {
                        price = 5.6;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else if (stock == "grapes")
                    {
                        price = 4.2;
                        Console.WriteLine($"{(price * amount):f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }


                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
