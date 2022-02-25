using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double change = double.Parse(Console.ReadLine())*100;
           // int changeToReturn = 
            int count = 0;
     
            while(change > 0)
            {
                if(change >= 200)
                {
                    change -= 200;
                    count++;
                }
               else if (change >= 100)// -1
                {
                    change -= 100;
                    count++;
                }
               else if (change >= 50)
                {
                    change -= 50;
                    count++;
                }
                else if (change >= 20)//-1
                {
                    change -= 20;
                    count++;
                }
               else if (change >= 10)
                {
                    change -= 10;
                    count++;
                }
             else if (change >= 5)
                {
                    change -= 5;
                    count++;
                }
           else if (change >= 2)//-1
                {
                    change -= 2;
                    count++;
                }
           else if (change >= 1)//-1
                {
                    change -= 1;
                    count++;
                }
                else
                {
                    change = 0;
                }
            }
            Console.WriteLine(count);
        }
    }
}
