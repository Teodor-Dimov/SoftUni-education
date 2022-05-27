using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double GradeSum = 0;
            int failcounter = 0;
            while (grade <= 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());
                if (yearlyGrade < 4)
                {
                    failcounter++;
                    if (failcounter == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    continue;
                }
                GradeSum += yearlyGrade;
                grade++;
            }
            double averagegrade = GradeSum / 12;
            if (failcounter < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averagegrade:f2}");
            }
        }
    }
}
