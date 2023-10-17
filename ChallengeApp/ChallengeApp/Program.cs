﻿using ChallengeApp;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witamy w programie S.T.A.T do oceny pracowników");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();

        var employee = new Employee("Cristiano", "Ronaldo");

        while (true)
        {
            Console.WriteLine("Podaj kolejną ocenę pracownika: ");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            employee.AddGrade(input);
        }

        var statistics = employee.GetStatistics();
        Console.WriteLine($"AVG: {statistics.Average}");
        Console.WriteLine($"AVG: {statistics.Min}");
        Console.WriteLine($"AVG: {statistics.Max}");
        Console.WriteLine($"AVG; {statistics.AverageLetter}");
    }

}