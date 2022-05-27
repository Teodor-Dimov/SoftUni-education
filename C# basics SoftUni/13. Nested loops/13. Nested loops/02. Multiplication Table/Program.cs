using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int a = 1; a <= 10; a++)
                {
                    int product = i * a;
                    Console.WriteLine($"{i} * {a} = {product}");
                }
            }
        }
    }
}
