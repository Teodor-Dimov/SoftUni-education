using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double space = double.Parse(Console.ReadLine());
            //double PRICE = 7.61;

            double discount = (space * 7.61) * 0.18;
            double sth = space * 7.61 - discount;
            Console.WriteLine($"The final price is: {sth} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
