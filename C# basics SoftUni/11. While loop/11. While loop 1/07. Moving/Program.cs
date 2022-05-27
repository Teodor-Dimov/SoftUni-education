using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double space = a * b * c;

            string box = Console.ReadLine();
            double input = 0;
            while (box != "Done")
            {
                //box = Console.ReadLine(input);
                input = double.Parse(box);
                if (space > input)
                {
                    space -= input;
                }
                else if (space < input)
                {

                    break;
                }
                else if (space == input)
                {
                    //space -= input;
                    break;
                }
                box = Console.ReadLine();





            }
            if (space - input > 0)
            {
                Console.WriteLine($"{space} Cubic meters left.");
            }
            else if (space - input < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(space - input)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{space - input} Cubic meters left.");
            }
            // else if (space==0)
            // {
            //     Console.WriteLine($"No more free space! You need {space} Cubic meters more.");
            // }
        }
    }
}
