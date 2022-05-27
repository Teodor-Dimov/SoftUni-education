using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalAmount = 0;
            while (input != "NoMoreMoney")
            {

                double money = double.Parse(input);

                if (money <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    //Console.WriteLine($"Total: {totalAmount:f2}");
                    break;
                }
                totalAmount += money;


                Console.WriteLine($"Increase: {money:f2}");
                // Console.WriteLine($"Total: {totalAmount:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalAmount:f2}");
        }
    }
}
