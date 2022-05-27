using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int himikal = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int preparat = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double price = (himikal * 5.8) + (7.2 * marker) + preparat * 1.2;
            double priceWithNamalenie = price - discount / 100 * price;
            Console.WriteLine(priceWithNamalenie);
        }
    }
}
