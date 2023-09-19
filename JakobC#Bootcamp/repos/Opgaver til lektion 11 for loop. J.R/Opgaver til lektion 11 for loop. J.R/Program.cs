// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//opgave 11.1
/*
Console.Write("Indtast navn her -> ");
string sBrugerNavn = Console.ReadLine();

for (int i = 0; i < sBrugerNavn.Length; i++) 
{
    Console.WriteLine(sBrugerNavn[i]);
}
*/

//opgave 11.2
/*
//opgave 11.1
Console.Write("Indtast navn her -> ");
string sBrugerNavn = Console.ReadLine();

for (int i = 0; i < sBrugerNavn.Length; i++)
{
    Console.WriteLine(sBrugerNavn[i]);
}

Console.WriteLine("");

for (int i = sBrugerNavn.Length-1; i > -1; i--)
{
    Console.WriteLine(sBrugerNavn[i]);
}
*/

//opgave 11.3
//ogpave 4.5
int x = 1;
int y = 80;
Console.SetCursorPosition(x, y);
int sleeper = 10;
Console.Write("╔");

for (x = 2; x < 13; x++)
{
    //4.4 part 1
    Thread.Sleep(sleeper);
    Console.SetCursorPosition(x, y);
    Console.Write("═");
}


x = 13;
Console.Write("╗");

for (x = 13; y < 82; y++)
{
    //4.4 part 1
    Thread.Sleep(sleeper);
    Console.SetCursorPosition(x, y + 1);
    Console.Write("║");
}

y = 83;
Console.SetCursorPosition(x, y);
Console.Write("╝");

for (x = 12; x > 1; x--)
{
    //4.4 part 1
    Thread.Sleep(sleeper);
    Console.SetCursorPosition(x, y);
    Console.Write("═");
}

x = 1;
Console.SetCursorPosition(x, y);
Console.Write("╚");


for (y = 83; y > 81; y--)
{
    //4.4 part 1
    Thread.Sleep(sleeper);
    Console.SetCursorPosition(x, y - 1);
    Console.Write("║");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();