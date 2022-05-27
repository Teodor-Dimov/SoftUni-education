using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                double chislo = double.Parse(Console.ReadLine());
                if (chislo < 200)
                {
                    p1++;
                }
                else if (chislo < 400)
                {
                    p2++;
                }
                else if (chislo < 600)
                {
                    p3++;
                }
                else if (chislo < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }





            }
            double convertP1 = 1.0 * p1 / num * 100;
            double convertP2 = 1.0 * p2 / num * 100;
            double convertP3 = 1.0 * p3 / num * 100;
            double convertP4 = 1.0 * p4 / num * 100;
            double convertP5 = 1.0 * p5 / num * 100;
            Console.WriteLine($"{convertP1:f2}%");
            Console.WriteLine($"{convertP2:f2}%");
            Console.WriteLine($"{convertP3:f2}%");
            Console.WriteLine($"{convertP4:f2}%");
            Console.WriteLine($"{convertP5:f2}%");
        }
    }
    }

