using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int num = a; num <= b; num++)
            {
                int currentNum = num;
                int evenSum = 0;
                int oddSum = 0;
                int count = 0;
                while (currentNum != 0)
                {
                    int digit = currentNum % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currentNum /= 10;
                    count++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write(num + " ");
                }

            }
        }
    }
}
