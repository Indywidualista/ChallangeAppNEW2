﻿using ChallengeApp;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witamy w programie S.T.A.T do oceny pracowników");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();

        var supervisor = new Supervisor("Kuba", "Gogolewski");

        while (true)
        {
            Console.WriteLine("Podaj kolejną ocenę pracownika: ");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }

            try
            {
                supervisor.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }

        var statistics = supervisor.GetStatistics();
        Console.WriteLine($"Average: {statistics.Average}");
        Console.WriteLine($"Min: {statistics.Min}");
        Console.WriteLine($"Max: {statistics.Max}");
        Console.WriteLine($"Letter: {statistics.AverageLetter}");
    }
}