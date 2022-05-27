using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double counter = 1;

            while (num >= counter)
            {
                Console.WriteLine(counter);
                counter = counter * 2 + 1;

            }
        }
    }
}
