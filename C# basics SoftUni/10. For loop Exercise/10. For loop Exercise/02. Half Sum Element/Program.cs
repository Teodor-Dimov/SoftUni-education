using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < numbers; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if (currentNum > max)
                {
                    max = currentNum;
                }
            }
            int sumWithoutMaxSum = sum - max;
            if (sumWithoutMaxSum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");

            }
            else
            {
                int difference = Math.Abs(sumWithoutMaxSum - max);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
