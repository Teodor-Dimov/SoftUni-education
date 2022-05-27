using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double seconds = double.Parse(Console.ReadLine());
            double metres = double.Parse(Console.ReadLine());
            double oneSpeed = double.Parse(Console.ReadLine());

            double slowDown = Math.Floor((metres) / 15) * 12.5;
            double record = metres * oneSpeed + slowDown;
            double successOrNot = Math.Abs(seconds - record);

            if (record >= seconds)
            {
                Console.WriteLine($"No, he failed! He was {successOrNot:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {record:f2} seconds.");
            }
        }
    }
}
