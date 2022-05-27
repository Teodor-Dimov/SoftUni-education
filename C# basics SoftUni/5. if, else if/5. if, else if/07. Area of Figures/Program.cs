using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            //double b = double.Parse(Console.ReadLine());

            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:f3}");
            }
            if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b:f3}");
            }
            if (shape == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a * a) * Math.PI:f3}");
            }
            if (shape == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b / 2:f3}");
            }
        }
    }
}
