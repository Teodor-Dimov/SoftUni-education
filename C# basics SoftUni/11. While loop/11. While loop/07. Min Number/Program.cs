using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = int.MaxValue;
            while (input != "Stop")
            {
                int currentNum = int.Parse(input);
                if (sum > currentNum)
                {
                    sum = currentNum;
                }




                input = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
