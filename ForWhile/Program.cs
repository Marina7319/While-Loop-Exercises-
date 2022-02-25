using System;

namespace ForWhile
{
    class Program
    {
        static void Main(string[] args)
        {
      
                string input = Console.ReadLine();
     
            Console.WriteLine("------------");

            int j = 1;
            while(input != "Stop")
            {
                Console.WriteLine("J =" + j);
                j++;
                input = Console.ReadLine();
            }
        }
    }
}
