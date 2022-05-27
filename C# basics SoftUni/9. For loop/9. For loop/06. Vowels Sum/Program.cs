using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int nameLenght = name.Length;
            int sum = 0;
            //char c = name[];
            for (int i = 0; i < nameLenght; i++)
            {
                char c = name[i];
                if (c == 'a')
                {
                    sum += 1;
                }
                if (c == 'e')
                {
                    sum += 2;
                }
                if (c == 'i')
                {
                    sum += 3;
                }
                if (c == 'o')
                {
                    sum += 4;
                }
                if (c == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
