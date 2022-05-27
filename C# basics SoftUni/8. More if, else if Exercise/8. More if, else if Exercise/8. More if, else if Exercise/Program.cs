using System;

namespace _8._More_if__else_if_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            const double Premiere = 12.00;
            const double Normal = 7.5;
            const double Discount = 5;

            double totalMoneyMade = 0;

            switch (projection)
            {
                case "Premiere":
                    totalMoneyMade = rows * columns * Premiere;
                    break;
                case "Normal":
                    totalMoneyMade = rows * columns * Normal;
                    break;
                default:
                    totalMoneyMade = rows * columns * Discount;
                    break;

            }

            Console.WriteLine($"{totalMoneyMade:f2} leva");
        }
    }
}
