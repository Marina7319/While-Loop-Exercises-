using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int daysCount = 0;
            int spendCount = 0;
            double moneyspend = 0;
            while (availableMoney < neededMoney && spendCount < 5)
            {
             string input = Console.ReadLine();
             double money = double.Parse(Console.ReadLine());
                daysCount++;
                if(input == "save")
                {
                    moneyspend += money;
                }
                else
                {
                    moneyspend += money;
                }
            }
            if (spendCount == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCount);
            }
            if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
