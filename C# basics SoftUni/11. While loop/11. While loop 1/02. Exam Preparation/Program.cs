using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BAD_GRADE = 4;

            int BadGrades = int.Parse(Console.ReadLine());
            int badGradesCount = 0;
            string problemName = Console.ReadLine();
            string lastproblem = "";
            double gradesum = 0;
            double allGrades = 0;

            while (problemName != "Enough")
            {
                int currentGrade = int.Parse(Console.ReadLine());
                gradesum++;
                allGrades += currentGrade;
                if (currentGrade <= BAD_GRADE)
                {
                    badGradesCount++;
                    if (badGradesCount == BadGrades)
                    {
                        break;
                    }

                }
                lastproblem = problemName;
                problemName = Console.ReadLine();
            }

            if (problemName == "Enough")
            {
                double averageScore = 1.0 * allGrades / gradesum;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {gradesum}");
                Console.WriteLine($"Last problem: {lastproblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGradesCount } poor grades.");
            }
        }
    }
}
