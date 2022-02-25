using System;

namespace _03.__Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            string input = "";
            double amount = 0;
            int spendCounter = 0;
            int deysCounter = 0;
            while (money < moneyNeeded)
            {
                input = Console.ReadLine();
                amount = int.Parse(Console.ReadLine());
                deysCounter++;

                if (input == "save")
                {
                    money += amount;
                    spendCounter = 0;
                }
                else
                {
                    money -= amount;

                    if (money < 0)
                    {
                        money = 0;
                    }

                    spendCounter++;

                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(deysCounter);
                        break;
                    }
                }
            }

            if (money >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {deysCounter} days.");
            }
        }
    }
}
