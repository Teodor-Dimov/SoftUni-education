﻿using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destiantion = Console.ReadLine();

            while (destiantion != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney < budget)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destiantion}!");

                destiantion = Console.ReadLine();
            }
        }
    }
}
