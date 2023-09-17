var number = 958855;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int a0 = 0;
int b1 = 0;
int c2 = 0;
int d3 = 0;
int e4 = 0;
int f5 = 0;
int g6 = 0;
int h7 = 0;
int i8 = 0;
int j9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        a0++;
    }
    else if (letter == '1')
    {
        b1++;
    }
    else if (letter == '2')
    {
        c2++;
    }
    else if (letter == '3')
    {
        d3++;
    }
    else if (letter == '4')
    {
        e4++;
    }
    else if (letter == '5')
    {
        f5++;
    }
    else if (letter == '6')
    {
        g6++;
    }
    else if (letter == '7')
    {
        h7++;
    }
    else if (letter == '8')
    {
        i8++;
    }
    else if (letter == '9')
    {
        j9++;
    }
}

Console.WriteLine("Wynik dla liczby: " + number);
Console.WriteLine("0 => " + a0);
Console.WriteLine("1 => " + b1);
Console.WriteLine("2 => " + c2);
Console.WriteLine("3 => " + d3);
Console.WriteLine("4 => " + e4);
Console.WriteLine("5 => " + f5);
Console.WriteLine("6 => " + g6);
Console.WriteLine("7 => " + h7);
Console.WriteLine("8 => " + i8);
Console.WriteLine("9 => " + j9);