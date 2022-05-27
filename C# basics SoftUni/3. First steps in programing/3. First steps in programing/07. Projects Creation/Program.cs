using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int project = int.Parse(Console.ReadLine());
            const int HOURS = 3;

            Console.WriteLine($"The architect {name} will need {project * HOURS} hours to complete {project} project/s.");
        }
    }
}
