using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int totalStudents = 0;
            int totalStandards = 0;
            int totalKids = 0;
            int totalTickets = 0;
            while (command != "Finish")
            {

                int students = 0;
                int standards = 0;
                int kid = 0;
                int freeSpots = int.Parse(Console.ReadLine());
                for (int i = 0; i < freeSpots; i++)
                {
                    string TicketType = Console.ReadLine();
                    if (TicketType == "End")
                    {
                        break;
                    }
                    else
                    {
                        switch (TicketType)
                        {
                            case "student":
                                students++;
                                break;
                            case "standard":
                                standards++;
                                break;
                            case "kid":
                                kid++;
                                break;
                            default:
                                break;
                        }
                    }
                }
                totalStudents += students;
                totalStandards += standards;
                totalKids += kid;
                double percentageFULL = ((students + standards + kid) / (double)freeSpots) * 100;
                Console.WriteLine($"{command} - {percentageFULL:f2}% full.");

                command = Console.ReadLine();
            }
            totalTickets = totalKids + totalStandards + totalStudents;
            Console.WriteLine($"Total tickets: {totalTickets}");
            double standardPercentage = totalStandards / (double)totalTickets * 100;
            double studentPercentage = totalStudents / (double)totalTickets * 100;
            double kidPercentage = totalKids / (double)totalTickets * 100;
            Console.WriteLine($"{studentPercentage:f2}% student tickets.");
            Console.WriteLine($"{standardPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidPercentage:f2}% kids tickets.");
        }
    }
}
