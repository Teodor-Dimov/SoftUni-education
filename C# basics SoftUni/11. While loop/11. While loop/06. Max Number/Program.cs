using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = int.MinValue;
            while (input != "Stop")
            {
                int currentNum = int.Parse(input);
                if (sum < currentNum)
                {
                    sum = currentNum;
                }




                input = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
