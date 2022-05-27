using System;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double cm = radians * 180 / Math.PI;
            Console.WriteLine(cm);
        }
    }
}
