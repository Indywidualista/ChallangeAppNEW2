using Microsoft.VisualBasic.FileIO;

var age = 16;
var name = "Ewa";
var gender = "male";

if (age == 33 && gender == "female" && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
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
else
{
    Console.WriteLine("Osoba jest pełnoletnia");
}
