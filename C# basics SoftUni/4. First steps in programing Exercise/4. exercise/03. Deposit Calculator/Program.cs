using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double month = double.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());
            double answer = money * (lihva / 100);
            double answer3 = answer / 12;
            double answer2 = money + month * answer3;
            Console.WriteLine(answer2);
        }
    }
}
