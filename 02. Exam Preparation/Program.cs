using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Запазим броя на незадоволителните оценки
            int failedThreshold = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = true;        
            while(failedTimes < failedThreshold)
            {
                string problemName = Console.ReadLine();
                if ( "Enough" == problemName)
                {
                    isFailed = false;
                    break;
                
                }
                int grade = int.Parse(Console.ReadLine());
                if(grade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedProblemsCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
