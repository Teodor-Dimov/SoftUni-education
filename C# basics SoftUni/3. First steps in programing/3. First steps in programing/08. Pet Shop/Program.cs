using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());
            const double PRICEDOG = 2.5;
            const int PRICECAT = 4;
            // double price = dog * PRICEDOG + cat * PRICECAT;
            Console.WriteLine($"{dog * PRICEDOG + cat * PRICECAT} lv.");
        }
    }
}
