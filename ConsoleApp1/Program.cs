using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string input;
            for(int i = 1; i <= 10; i++)
            {
                input = Console.ReadLine();

                if(input == "No")
                {
                    continue;
                }
                int num = int.Parse(input);
                Console.WriteLine(num * 2);
               // Console.WriteLine(num * 2);
            }
        }
    }
}
