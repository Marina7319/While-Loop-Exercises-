using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int count = 0; 
            string input = Console.ReadLine();
            while (input != "No More Books")
            {
                if (input == bookName)
                {
                    break;
                }
                count++;
                input = Console.ReadLine();
            }
            if (input == bookName)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            } else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
