using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            int vichlo = chislo;
            double sum = 0;
            double sum2 = 0;
            for (int i = 0; i < chislo; i++)
            {
                if (i % 2 == 0)
                {
                    double Candice = double.Parse(Console.ReadLine());
                    sum2 += Candice;
                }

                else
                {
                    double candice = double.Parse(Console.ReadLine());
                    sum += candice;
                }



            }

            if (sum == sum2)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sum - sum2)}");
            }
        }
    }
}
