using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chicken = double.Parse(Console.ReadLine());
            double fish = double.Parse(Console.ReadLine());
            double vegan = double.Parse(Console.ReadLine());
            double price1 = chicken * 10.35 + 12.40 * fish + 8.15 * vegan;
            double price = price1 + price1 * 0.2 + 2.5;
            Console.WriteLine(price);
        }
    }
}
