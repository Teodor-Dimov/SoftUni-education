using System;

namespace _12._While_loop_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int countedBooks = 0;
            string book = Console.ReadLine();
            while (book != "No More Books")
            {
                if (book == searchedBook)
                {
                    Console.WriteLine($"You checked {countedBooks} books and found it.");
                    break;
                }
                countedBooks++;
                book = Console.ReadLine();

            }
            if (book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countedBooks} books.");

            }
        }
    }
}
