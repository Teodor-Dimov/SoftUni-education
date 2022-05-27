using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sumOfPrimeNums = 0;
            int sumOfNonPrimeNums = 0;
            while (command != "stop")
            {
                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;

                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }


                    }
                    if (count == 2)
                    {
                        sumOfPrimeNums += number;
                    }
                    else
                    {
                        sumOfNonPrimeNums += number;
                    }



                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNums}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNums}");
        }
    }
}
