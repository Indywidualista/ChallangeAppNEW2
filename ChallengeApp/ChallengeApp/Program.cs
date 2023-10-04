using ChallengeApp;
class MainClass
{
    public static void Main(string[] args)
    {
        var employee = new Employee("Maciej", "Palec");
        employee.AddGrade(101);
        employee.AddGrade("Sto");
        employee.AddGrade("");
        employee.AddGrade(2);
        employee.AddGrade(6);
        var statistics = employee.GetStatistics();

        Console.WriteLine($"Average: {statistics.Average:N2}");
        Console.WriteLine($"Min: {statistics.Min}");
        Console.WriteLine($"Max: {statistics.Max}");
    }
}