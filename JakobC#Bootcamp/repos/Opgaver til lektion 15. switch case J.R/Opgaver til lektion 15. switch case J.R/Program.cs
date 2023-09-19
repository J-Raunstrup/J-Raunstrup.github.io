// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//opgave 15.1
//opgave 13.1 gjort til kommentar for at løse næste opgave.
/*
//7.15


menu();
brugerindtastning();

//program menu metode
static void menu()
{
    Console.WriteLine("Areal beregner");
    Console.WriteLine("Dette program kan beregne arealet af en af nedstående former:");
    Console.WriteLine("kvadrat: 1");
    Console.WriteLine("trekant: 2");
    Console.WriteLine("rektangel: 3");
    //tilføjet til 13.1
    Console.WriteLine("Cirkel: 4");
}

//brugerindtastnings metode.
static void brugerindtastning()
{
    Console.Write("Skriv tallet på formen man ønsker at udregne arealet på her (1/2/3/4) -> ");
    string sBrugerSvar = Console.ReadLine();
    double dBrugerSvar = Convert.ToDouble(sBrugerSvar);
    double arealAfKvadrat = 0;
    double arealAfTrekant = 0;
    double arealAfRektangel = 0;
    //tilføjet til 13.1
    double arealAfCirkel = 0;
    if (sBrugerSvar == "1")
    {
        Console.WriteLine("Du har valgt et kvadrat. For at beregne arealet skal jeg bruge 2 værdier. Højden og bredden. (1 ud af 3)");
        Console.Write("Hvad er højden? (2 ud af 3) -> ");
        string sHøjde = Console.ReadLine();
        Console.Write("Hvad er bredden? (3 ud af 3) -> ");
        string sBredde = Console.ReadLine();
        double dHøjde = Convert.ToDouble(sHøjde);
        double dBredde = Convert.ToDouble(sBredde);
        arealAfKvadrat = arealBeregnerKvadrat(dHøjde, dBredde);
    }
    else if (sBrugerSvar == "2")
    {
        Console.WriteLine("Du har valgt en trekant. For at beregne arealet skal jeg bruge 2 værdier. Højden og grundlinjen. (1 ud af 3)");
        Console.Write("Hvad er højden? (2 ud af 3) -> ");
        string sHøjde = Console.ReadLine();
        Console.Write("Hvad er grundlinjen? (3 ud af 3) -> ");
        string sBredde = Console.ReadLine();
        double dHøjde = Convert.ToDouble(sHøjde);
        double dBredde = Convert.ToDouble(sBredde);
        arealAfTrekant = arealBeregnerTrekant(dHøjde, dBredde);
    }
    else if (sBrugerSvar == "3")
    {
        Console.WriteLine("Du har valgt en rektangel. For at beregne arealet skal jeg bruge 2 værdier. Højden og bredden. (1 ud af 3)");
        Console.Write("Hvad er højden? (2 ud af 3) -> ");
        string sHøjde = Console.ReadLine();
        Console.Write("Hvad er bredden? (3 ud af 3) -> ");
        string sBredde = Console.ReadLine();
        double dHøjde = Convert.ToDouble(sHøjde);
        double dBredde = Convert.ToDouble(sBredde);
        arealAfRektangel = arealBeregnerRektangel(dHøjde, dBredde);
    }
    //tilføjet til 13.1
    else if (sBrugerSvar == "4")
    {
        Console.WriteLine("Du har valgt en cirkel. For at beregne arealet skal jeg bruge radius værdien på cirklen. (1 ud af 2)");
        Console.Write("Hvad er cirklens radius? (2 ud af 2) -> ");
        string sRadius = Console.ReadLine();
        double dRadius = Convert.ToInt32(sRadius);
        //brug metode på en linje under her senere efter metode til cirkel beregning er lavet.
        arealAfCirkel = arealBeregnerCirkel(dRadius);
    }
    else
    {
        Console.WriteLine("Ikke en kendt svar mulighed");
    }
    resultatOutput(arealAfKvadrat, arealAfTrekant, arealAfRektangel, dBrugerSvar, arealAfCirkel);
}

//arealberegnings metoder
static double arealBeregnerKvadrat(double dHøjde, double dBredde)
{
    return dHøjde * dBredde;
}

static double arealBeregnerTrekant(double dHøjde, double dBredde)
{
    return (dHøjde * dBredde) / 2;
}

static double arealBeregnerRektangel(double dHøjde, double dBredde)
{
    return dHøjde * dBredde;
}

//tilføjet til 13.1
static double arealBeregnerCirkel(double dRadius) 
{
    return (Math.Pow(dRadius, 2) * Math.PI);
}

//metode til output af resultat
static void resultatOutput(double arealAfKvadrat, double arealAfTrekant, double arealAfRektangel, double dBrugerSvar, double arealAfCirkel)
{
    if (dBrugerSvar == 1)
    {
        Console.WriteLine(arealAfKvadrat);
    }
    else if (dBrugerSvar == 2)
    {
        Console.WriteLine(arealAfTrekant);
    }
    else if (dBrugerSvar == 3)
    {
        Console.WriteLine(arealAfRektangel);
    }
    else if (dBrugerSvar == 4)
    {
        Console.WriteLine(arealAfCirkel);
    }
    else
    {
        Console.WriteLine("Error");
    }
}
*/
//opgave 13.1 gjort til kommentar for at løse næste opgave.


//opgave 15.1 gjort itl kommentar for at løse næste opgave.
//opgave 7.15

/*
menu();
brugerindtastning();

//program menu metode
static void menu()
{
    Console.WriteLine("Areal beregner");
    Console.WriteLine("Dette program kan beregne arealet af en af nedstående former:");
    Console.WriteLine("kvadrat: 1");
    Console.WriteLine("trekant: 2");
    Console.WriteLine("rektangel: 3");
    //tilføjet til 13.1
    Console.WriteLine("Cirkel: 4");
}

//brugerindtastnings metode.
static void brugerindtastning()
{
    Console.Write("Skriv tallet på formen man ønsker at udregne arealet på her (1/2/3/4) -> ");
    string sBrugerSvar = Console.ReadLine();
    double dBrugerSvar = Convert.ToDouble(sBrugerSvar);
    double arealAfKvadrat = 0;
    double arealAfTrekant = 0;
    double arealAfRektangel = 0;
    //tilføjet til 13.1
    double arealAfCirkel = 0;
    switch (sBrugerSvar)
    {
        case "1":
            Console.WriteLine("Du har valgt et kvadrat. For at beregne arealet skal jeg bruge 2 værdier. Højden og bredden. (1 ud af 3)");
            Console.Write("Hvad er højden? (2 ud af 3) -> ");
            string sHøjde = Console.ReadLine();
            Console.Write("Hvad er bredden? (3 ud af 3) -> ");
            string sBredde = Console.ReadLine();
            double dHøjde = Convert.ToDouble(sHøjde);
            double dBredde = Convert.ToDouble(sBredde);
            arealAfKvadrat = arealBeregnerKvadrat(dHøjde, dBredde);
            break;
        case "2":
            Console.WriteLine("Du har valgt en trekant. For at beregne arealet skal jeg bruge 2 værdier. Højden og grundlinjen. (1 ud af 3)");
            Console.Write("Hvad er højden? (2 ud af 3) -> ");
            sHøjde = Console.ReadLine();
            Console.Write("Hvad er grundlinjen? (3 ud af 3) -> ");
            sBredde = Console.ReadLine();
            dHøjde = Convert.ToDouble(sHøjde);
            dBredde = Convert.ToDouble(sBredde);
            arealAfTrekant = arealBeregnerTrekant(dHøjde, dBredde);
            break;
        case "3":
            Console.WriteLine("Du har valgt en rektangel. For at beregne arealet skal jeg bruge 2 værdier. Højden og bredden. (1 ud af 3)");
            Console.Write("Hvad er højden? (2 ud af 3) -> ");
            sHøjde = Console.ReadLine();
            Console.Write("Hvad er bredden? (3 ud af 3) -> ");
            sBredde = Console.ReadLine();
            dHøjde = Convert.ToDouble(sHøjde);
            dBredde = Convert.ToDouble(sBredde);
            arealAfRektangel = arealBeregnerRektangel(dHøjde, dBredde);
            break;
        case "4":
            Console.WriteLine("Du har valgt en cirkel. For at beregne arealet skal jeg bruge radius værdien på cirklen. (1 ud af 2)");
            Console.Write("Hvad er cirklens radius? (2 ud af 2) -> ");
            string sRadius = Console.ReadLine();
            double dRadius = Convert.ToInt32(sRadius);
            //brug metode på en linje under her senere efter metode til cirkel beregning er lavet.
            arealAfCirkel = arealBeregnerCirkel(dRadius);
            break;
        default:
            Console.WriteLine("Ikke en kendt svar mulighed");
            break;
    }
    resultatOutput(arealAfKvadrat, arealAfTrekant, arealAfRektangel, dBrugerSvar, arealAfCirkel);
}

//arealberegnings metoder
static double arealBeregnerKvadrat(double dHøjde, double dBredde)
{
    return dHøjde * dBredde;
}

static double arealBeregnerTrekant(double dHøjde, double dBredde)
{
    return (dHøjde * dBredde) / 2;
}

static double arealBeregnerRektangel(double dHøjde, double dBredde)
{
    return dHøjde * dBredde;
}

//tilføjet til 13.1
static double arealBeregnerCirkel(double dRadius) 
{
    return (Math.Pow(dRadius, 2) * Math.PI);
}

//metode til output af resultat
static void resultatOutput(double arealAfKvadrat, double arealAfTrekant, double arealAfRektangel, double dBrugerSvar, double arealAfCirkel)
{
    switch (dBrugerSvar) 
    {
        case 1:
            Console.WriteLine(arealAfKvadrat);
            break;
        case 2:
            Console.WriteLine(arealAfTrekant);
            break;
        case 3:
            Console.WriteLine(arealAfRektangel);
            break;
        case 4:
            Console.WriteLine(arealAfCirkel);
            break;
        default:
            Console.WriteLine("Error");
            break;
    }

}
*/

//opgave 7.13 gjort til kommentar for at løse næste opgave.
/*
//opgave 2.5
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
Console.WriteLine("HR assignment");
Console.SetCursorPosition(5, 3);
Console.Write("Vælg: (E)fternavn, (F)ornavne, (C)pr, (A)fdeling, (T)itel, (S)kills, (Q)uit : O");
Console.SetCursorPosition(5, 5);
Console.Write("CPR :");
Console.SetCursorPosition(25, 5);
Console.Write("Efternavn :");
Console.SetCursorPosition(5, 7);
Console.Write("Alder :");
Console.SetCursorPosition(25, 7);
Console.Write("Fornavne :");
Console.SetCursorPosition(5, 9);
Console.Write("Køn :");
Console.SetCursorPosition(25, 9);
Console.Write("Afdeling :");
Console.SetCursorPosition(25, 11);
Console.Write("Titel :");
Console.SetCursorPosition(5, 13);
Console.WriteLine("Skills :");
Console.WriteLine("Tryk på en af de følgende taster: E, F, C, A, T, S, Q");
string sBrugerIndtastning = Console.ReadLine();
do {
    if (sBrugerIndtastning == "E")
    {
        Console.SetCursorPosition(37, 5);
        string sEIndtastning = Console.ReadLine();
    }
    else if (sBrugerIndtastning == "F")
    {
        Console.SetCursorPosition(37, 7);
        string sFIndtastning = Console.ReadLine();
    }
    else if (sBrugerIndtastning == "C")
    {
        Console.SetCursorPosition(11, 5);
        string sCIndtastning = Console.ReadLine();
    }
    else if (sBrugerIndtastning == "A")
    {
        Console.SetCursorPosition(36, 9);
        string sAIndtastning = Console.ReadLine();
    }
    else if (sBrugerIndtastning == "T")
    {
        Console.SetCursorPosition(33, 11);
        string sTIndtastning = Console.ReadLine();
    }
    else if (sBrugerIndtastning == "S")
    {
        Console.SetCursorPosition(14, 13);
        string sSIndtastning = Console.ReadLine();
    }
    else if (sBrugerIndtastning == "F")
    {
        Console.SetCursorPosition(37, 5);
        string sFIndtastning = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Ukendt input");
    }
    sBrugerIndtastning = Console.ReadLine();
} while (sBrugerIndtastning != "Q");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
*/


/**/
//opgave 15.2
//opgave 7.13 gjort til kommentar for at løse næste opgave.

//opgave 2.5
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
Console.WriteLine("HR assignment");
Console.SetCursorPosition(5, 3);
Console.Write("Vælg: (E)fternavn, (F)ornavne, (C)pr, (A)fdeling, (T)itel, (S)kills, (Q)uit : O");
Console.SetCursorPosition(5, 5);
Console.Write("CPR :");
Console.SetCursorPosition(25, 5);
Console.Write("Efternavn :");
Console.SetCursorPosition(5, 7);
Console.Write("Alder :");
Console.SetCursorPosition(25, 7);
Console.Write("Fornavne :");
Console.SetCursorPosition(5, 9);
Console.Write("Køn :");
Console.SetCursorPosition(25, 9);
Console.Write("Afdeling :");
Console.SetCursorPosition(25, 11);
Console.Write("Titel :");
Console.SetCursorPosition(5, 13);
Console.WriteLine("Skills :");
Console.WriteLine("Tryk på en af de følgende taster: E, F, C, A, T, S, Q");
string sBrugerIndtastning = Console.ReadLine();
do {
    switch (sBrugerIndtastning) 
    {
        case "E":
            Console.SetCursorPosition(37, 5);
            string sEIndtastning = Console.ReadLine();
            break;
        case "F":
            Console.SetCursorPosition(37, 7);
            string sFIndtastning = Console.ReadLine();
            break;
        case "C":
            Console.SetCursorPosition(11, 5);
            string sCIndtastning = Console.ReadLine();
            break;
        case "A":
            Console.SetCursorPosition(36, 9);
            string sAIndtastning = Console.ReadLine();
            break;
        case "T":
            Console.SetCursorPosition(33, 11);
            string sTIndtastning = Console.ReadLine();
            break;
        case "S":
            Console.SetCursorPosition(14, 13);
            string sSIndtastning = Console.ReadLine();
            break;
        //fjernet da dette ligner duplicate kode
        /*
    case "F":
        Console.SetCursorPosition(37, 5);
        string sFIndtastning = Console.ReadLine();
        break;
        */
        default:
            Console.WriteLine("Ukendt input");
            break;
    }
    sBrugerIndtastning = Console.ReadLine();
} while (sBrugerIndtastning != "Q");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
