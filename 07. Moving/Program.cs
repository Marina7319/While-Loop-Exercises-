using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int xyz = x * y * z;
            string text = Console.ReadLine();
            while (text != "Done")
            {
                sum += int.Parse(text);
                if (sum > xyz)
                {
                    break;
                }
                text = Console.ReadLine();
            }
            if (text == "Done")
            {
                Console.WriteLine($"{xyz-sum} Cubic meters left.");
            }
            if(xyz < sum)
            {
                Console.WriteLine($"No more free space! You need {sum-xyz} Cubic meters more.");
            }
        }
    }
}
