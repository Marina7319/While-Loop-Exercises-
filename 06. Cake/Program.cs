using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int pieces = 0;
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int sum = h * w;
            string text = Console.ReadLine();        
            while (text != "STOP")
            {
                pieces += int.Parse(text);
                if(sum <= pieces)
                {
                    break;
                }
                text = Console.ReadLine();
            }
            if(pieces >= sum)
            {              
                Console.WriteLine($"No more cake left! You need {pieces - sum} pieces more.");
            }
            if (text == "STOP")
            {
                Console.WriteLine($"{sum - pieces} pieces are left.");               
            }
        }
    }
}
