using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int AllPeacesOfCake = lenght * width;
            while (AllPeacesOfCake > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }

                int peaceOfCake = int.Parse(input);
                AllPeacesOfCake -= peaceOfCake;

            }
            if (AllPeacesOfCake >= 0)
            {
                Console.WriteLine($"{AllPeacesOfCake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(AllPeacesOfCake)} pieces more.");
            }
        }
    }
}
