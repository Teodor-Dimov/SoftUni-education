using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine(1);
            }
            else if (number == 2)
            {
                Console.WriteLine(1);
                Console.WriteLine(4);
            }
            else
            {
                Console.WriteLine(1);
                Console.WriteLine(4);


            }
            int sum = 4;
            int zum = 4;
            for (int i = 0; i < number - 2; i += 2)
            {


                sum = 4;

                int dum = zum * sum;
                zum = dum;
                Console.WriteLine(dum);

            }
        }
    }
}
