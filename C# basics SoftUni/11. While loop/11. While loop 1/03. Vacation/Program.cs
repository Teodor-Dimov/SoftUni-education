using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needVacationMoney = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spendcounter = 0;

            while (spendcounter != 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (input == "save")
                {
                    currentMoney += money;
                    spendcounter = 0;
                }
                else if (input == "spend")
                {
                    spendcounter++;
                    if (currentMoney < money)
                    {
                        currentMoney = 0;
                    }
                    else
                    {
                        currentMoney -= money;
                    }


                }
                if (currentMoney >= needVacationMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;


                }
            }
            if (spendcounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{days}");
            }
        }
    }
}
