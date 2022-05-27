using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double litres = a * b * c / 1000;
            double answer = litres * (1 - percent / 100);
            Console.WriteLine(answer);
        }
    }
}
