using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradus = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string clothes = "";
            string shoes = "";

            switch (timeOfDay)
            {
                case "Morning":
                    if (gradus >= 10 && gradus <= 18)
                    {
                        clothes = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    if (gradus > 18 && gradus <= 24)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    if (gradus >= 25)
                    {
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (gradus >= 10 && gradus <= 18)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    if (gradus > 18 && gradus <= 24)
                    {
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                    }
                    if (gradus >= 25)
                    {
                        clothes = "Swim Suit";
                        shoes = "Barefoot";
                    }

                    break;
                case "Evening":
                    if (gradus >= 10 && gradus <= 18)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    if (gradus > 18 && gradus <= 24)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    if (gradus >= 25)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }

                    break;

                default:
                    break;
            }

            Console.WriteLine($"It's {gradus} degrees, get your {clothes} and {shoes}.");

        }
    }
}
