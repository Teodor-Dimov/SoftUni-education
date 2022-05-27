using System;

namespace _11._While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string Stop = Console.ReadLine();
            while (Stop != "Stop")
            {
                Console.WriteLine(Stop);
                Stop = Console.ReadLine();

            }
        }
    }
}
