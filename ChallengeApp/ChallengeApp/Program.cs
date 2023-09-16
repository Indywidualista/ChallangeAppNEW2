using Microsoft.VisualBasic.FileIO;

var age = 33;
var name = "Ewa";
var gender = "female";

if (age == 33 && gender == "female" && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 30 && gender == "female")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (age < 18 && !(gender == "female"))
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (age > 33)
{
    Console.WriteLine("Osoba ma więcej niż 33 lata");
}
if (age > 17)
{
    Console.WriteLine("Osoba jest pełnoletnia");
}
