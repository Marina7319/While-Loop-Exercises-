using System;

namespace Vaccation
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyNeededForTravelling = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int deysCounter = 0;
            int spendingCounter = 0;


            while (budget < moneyNeededForTravelling && spendingCounter < 5)
            {
                string saveOrSpend = Console.ReadLine();
                int savings = int.Parse(Console.ReadLine());
                deysCounter++;
                if (spendingCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(deysCounter);
                }
                if (moneyNeededForTravelling >= budget)
                {
                    Console.WriteLine($"You saved the money for {deysCounter} days.");
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(deysCounter);
            }
            if (moneyNeededForTravelling >= budget)
            {
                Console.WriteLine($"You saved the money for {deysCounter} days.");
            }
        }
        }
    }

