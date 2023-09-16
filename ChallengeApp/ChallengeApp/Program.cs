using Microsoft.VisualBasic.FileIO;

var age = 19;
var name = "Ewa";
var gender = "male";

if (age == 33 && gender == "female")
{
    if (name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (age < 30 && gender == "female")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age < 18 && !(gender == "female"))
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (age > 33)
{
    Console.WriteLine("Osoba ma więcej niż 33 lata");
}
if (age > 17 && gender == "male" || gender == "female")
{
    Console.WriteLine("Osoba jest pełnoletnia");
}
