// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//opgave 8.1 gjort til kommentar for at løse næste opgave.
/*
bool bBlåØjne;
Console.Write("Har du blå øjne? [j/n] -> ");
if (Console.ReadLine() == "j")
{
    bBlåØjne = true;
}
else
{
    bBlåØjne = false;
}

if (bBlåØjne == true)
{
    Console.WriteLine("Du har blå øjne");
}
else if (bBlåØjne == false)
{
    Console.WriteLine("Du har ikke blå øjne");
}
else 
{
    Console.WriteLine("Ukendt svar");
}
*/

//opgave 8.2
bool bRig;
bool bBerømt;
bool bSmuk;
bool bRask;

Console.Write("Er du rig? [j/n] -> ");
string sRigSvar = Console.ReadLine();

Console.Write("Er du berømt? [j/n] -> ");
string sBerømtSvar = Console.ReadLine();

Console.Write("Er du smuk? [j/n] -> ");
string sSmukSvar = Console.ReadLine();

Console.Write("Er du rask? [j/n] -> ");
string sRaskSvar = Console.ReadLine();

if (sRigSvar == "j" && sBerømtSvar == "j" && sSmukSvar == "j" && sRaskSvar == "j")
{
    Console.WriteLine("Du er heldig");
}
//nedstående 4 linjer tilføjet for sjovs skyld. resten efter dette del af originale opgave.
else if (sRigSvar == "n" && sBerømtSvar == "n" && sSmukSvar == "n" && sRaskSvar == "n")
{
    Console.WriteLine("Det lyder godt nok ikke nemt.");
}
else if (sRigSvar == "n")
{
    Console.WriteLine("Få et job!");
}
else if (sSmukSvar == "n")
{
    Console.WriteLine("Overvej makeup eller pænere tøj!");
}
else if (sBerømtSvar == "n")
{
    Console.WriteLine("Deltag i et fjollet TV-program!");
}
else if (sRaskSvar == "n")
{
    Console.WriteLine("Gå til lægen!");
}
else
{
    Console.WriteLine("Ukendt svar.");
}