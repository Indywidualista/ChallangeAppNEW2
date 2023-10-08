using ChallengeApp;
class MainClass
{
    public static void Main(string[] args)
    {
        var employee = new Employee("Maciej", "Palec");
        employee.AddGrade(10);
        employee.AddGrade(8);
        employee.AddGrade(5);
        employee.AddGrade(2);
        employee.AddGrade(6);
        var statistics = employee.GetStatistics();
        var statistics1 = employee.GetStatisticsWithForEach();
        var statistics2 = employee.GetStatisticsWithFor();
        var statistics3 = employee.GetStatisticsWithDoWhile();

        Console.WriteLine("---While---");
        Console.WriteLine($"Average: {statistics.Average:N2}");
        Console.WriteLine($"Min: {statistics.Min}");
        Console.WriteLine($"Max: {statistics.Max}");
        Console.WriteLine("--ForEach--");
        Console.WriteLine($"Average: {statistics1.Average:N2}");
        Console.WriteLine($"Min: {statistics1.Min}");
        Console.WriteLine($"Max: {statistics1.Max}");
        Console.WriteLine("----For----");
        Console.WriteLine($"Average: {statistics2.Average:N2}");
        Console.WriteLine($"Min: {statistics2.Min}");
        Console.WriteLine($"Max: {statistics2.Max}");
        Console.WriteLine("--DoWhile--");
        Console.WriteLine($"Average: {statistics3.Average:N2}");
        Console.WriteLine($"Min: {statistics3.Min}");
        Console.WriteLine($"Max: {statistics3.Max}");
    }
}