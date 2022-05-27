using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int chas = int.Parse(Console.ReadLine());
            double rezult = (nailon + 2) * 1.5 + (boq + boq * 0.1) * 14.5 + 0.4 + razreditel * 5;
            double result2 = rezult * 0.3 * chas + rezult;
            Console.WriteLine(result2);
        }
    }
}
