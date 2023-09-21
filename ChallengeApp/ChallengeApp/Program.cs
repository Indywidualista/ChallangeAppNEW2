using ChallengeApp;

Employee user1 = new Employee("Jan", "Kowaslki", "25");
Employee user2 = new Employee("Tomek", "Nowak", "20");
Employee user3 = new Employee("Grażyna", "Graża", "47");

user1.AddScore(5);
user1.AddScore(8);
user1.AddScore(3);
user1.AddScore(9);
user1.AddScore(8);

user2.AddScore(8);
user2.AddScore(8);
user2.AddScore(6);
user2.AddScore(5);
user2.AddScore(10);

user3.AddScore(9);
user3.AddScore(7);
user3.AddScore(2);
user3.AddScore(5);
user3.AddScore(1);

List<Employee> employees = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;

Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
var name = employeeWithMaxResult.Name;
var surname = employeeWithMaxResult.Surname;
var age = employeeWithMaxResult.Age;
var result = employeeWithMaxResult.Result;

Console.WriteLine
    ("Najwyższy wynik w zestawieniu pracowników uzyskał/a: " + name + " " + surname + " " + age + "lat " + "z ilością punktów -> " + maxResult);

