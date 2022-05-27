using System;

namespace _09._Left_and_Right_Sum
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
                double candice = double.Parse(Console.ReadLine());
                sum += candice;
            }
            for (int i = 0; i < vichlo; i++)
            {
                double Candice = double.Parse(Console.ReadLine());
                sum2 += Candice;
            }
            if (sum == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum - sum2)}");
            }
        }
    }
}
