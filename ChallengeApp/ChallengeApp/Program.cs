﻿using ChallengeApp;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witamy w programie S.T.A.T do oceny pracowników");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();

        var employee = new EmployeeInFile("Tomasz", "Hajto");
        employee.GradeAdded += EmployeeGradeAdded;

        void EmployeeGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Dodano nową ocenę");
        }
 
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
                employee.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }

        var statistics = employee.GetStatistics();
        Console.WriteLine($"Average: {statistics.Average}");
        Console.WriteLine($"Min: {statistics.Min}");
        Console.WriteLine($"Max: {statistics.Max}");
        Console.WriteLine($"Letter: {statistics.AverageLetter}");
    }

}