using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int gradeCount = 0;
            double sumOfAllGrades = 0;
            while (input != "Finish")
            {
                double sumOfGrades = 0;
                for (int i = 1; i <= people; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    sumOfAllGrades += grade;
                    gradeCount++;


                }
                double averageForCurrentPresentation = sumOfGrades / people;
                Console.WriteLine($"{input} - {averageForCurrentPresentation:f2}.");
                input = Console.ReadLine();
            }

            double finalAverageGrade = sumOfAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is { finalAverageGrade:f2}.");
        }
    }
}
