// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//opgave 9.1
/*
//opgave 8.2
Console.WriteLine(spørgeskema());
static string spørgeskema()
{
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
    Console.Write("Ønsker du at køre programmet igen [j/n] -> ");
    char cBrugerSvar = Console.ReadKey().KeyChar;
    Console.WriteLine("");
    while (cBrugerSvar == 'j') 
    {
        return spørgeskema();
    }
    return "Program stoppet";
}
*/

//opgave 9.2
/*
Console.Write("Skriv venligst navn her -> ");
string sBrugerNavn = Console.ReadLine();
Console.WriteLine("Navnet " + sBrugerNavn + " er " + sBrugerNavn.Length + " tegn langt");
*/

//opgave 9.3
/*
//opgave 9.2
Console.Write("Skriv venligst navn her -> ");
string sBrugerNavn = Console.ReadLine();
Console.WriteLine("Navnet " + sBrugerNavn + " er " + sBrugerNavn.Length + " tegn langt");
Console.WriteLine("Første tegn: " + sBrugerNavn[0]);
Console.WriteLine("Sidste tegn: " + sBrugerNavn[sBrugerNavn.Length - 1]);
*/

//opgave 9.4
//meget hjælp fået. Forstod ikke helt.
/*
Console.Write("Skriv fulde navn her -> ");
string sBrugerNavn = Console.ReadLine();
int index = 0;
do
{
    index = sBrugerNavn.IndexOf(" ");
    if (index == -1)
    {
        Console.WriteLine(sBrugerNavn);
    }
    else
    {
        string kopier = sBrugerNavn.Substring(0, index);
        Console.WriteLine(kopier);
        sBrugerNavn = sBrugerNavn.Substring(index + 1);
    }
} while (index != -1);
*/

//opgave 9.5
/*
 svar: jeg antager at trimEnd() fjerner whitespace i slutningen af en string. så f.eks. hvis man havde en string og brugte trimEnd() på den.:

string test = "     mit navn er bobby        ";
test = test.trimEnd();
Console.WriteLine(test);
//output: "     mit navn er bobby"

hvorimod hvis vi brugte det modsatte trimStart() på det samme. Så ville det give følgende:

string test = "     mit navn er bobby        ";
test = test.trimStart();
Console.WriteLine(test);
//output: "mit navn er bobby        "
 */

//opgave 9.6
//løsning mulighed 1/2
//skrevet med index i focus og chars.
/*
Console.Write("Skriv fornavn her -> ");
string sFornavn = Console.ReadLine();
Console.Write("Skriv efternavn her -> ");
string sEfternavn = Console.ReadLine();
string targetFornavn = "";
string targetEfternavn = "";
int index = 0;

do
{
    if (index == 0)
    {
        string sFornavnFørsteTegn = Convert.ToString(sFornavn[index]);
        sFornavnFørsteTegn = sFornavnFørsteTegn.ToUpper();
        targetFornavn = targetFornavn + sFornavnFørsteTegn;
        index++;
    }
    else 
    {
        string sFornavnResterendeTegn = Convert.ToString(sFornavn[index]);
        sFornavnResterendeTegn = sFornavnResterendeTegn.ToLower();
        targetFornavn = targetFornavn + sFornavnResterendeTegn;
        index++;
    }
} while (index < sFornavn.Length);

index = 0;

do
{
    if (index == 0)
    {
        string sEfternavnFørsteTegn = Convert.ToString(sEfternavn[index]);
        sEfternavnFørsteTegn = sEfternavnFørsteTegn.ToUpper();
        targetEfternavn = targetEfternavn + sEfternavnFørsteTegn;
        index++;
    }
    else 
    {
        string sEfternavnResterendeTegn = Convert.ToString(sEfternavn[index]);
        sEfternavnResterendeTegn = sEfternavnResterendeTegn.ToLower();
        targetEfternavn = targetEfternavn + sEfternavnResterendeTegn;
        index++;
    }
} while (index < sEfternavn.Length);

string targetFuldenavn = targetFornavn + " " + targetEfternavn;
Console.WriteLine(targetFuldenavn);
*/

//løsning mulighed 2/2
//med substring.
/*
Console.Write("Skriv fornavn her -> ");
string sFornavn = Console.ReadLine();
Console.Write("Skriv efternavn her -> ");
string sEfternavn = Console.ReadLine();
int index = 0;

string substringFornavnStart = sFornavn.Substring(index, 1);
substringFornavnStart = substringFornavnStart.ToUpper();

string substringFornavnRest = sFornavn.Substring(1);
substringFornavnRest = substringFornavnRest.ToLower();

string outputFornavn = substringFornavnStart + substringFornavnRest;

index = 0;
string substringEfternavnStart = sEfternavn.Substring(index, 1);
substringEfternavnStart = substringEfternavnStart.ToUpper();

string substringEfternavnRest = sEfternavn.Substring(1);
substringEfternavnRest = substringEfternavnRest.ToLower();

string outputEfternavn = substringEfternavnStart + substringEfternavnRest;

string outputFuldenavn = outputFornavn + " " + outputEfternavn;
Console.WriteLine(outputFuldenavn);
*/

//opgave 9.7
//opgave 7.14 gjort til kommentar for at løse næste opgave.

//opgave 2.5
/*
using Microsoft.Win32.SafeHandles;
using System.Security.Cryptography.X509Certificates;
*/
/*
DrawScreen();
UserInput();
DrawBoxAround();


static void DrawScreen()
{
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
}
static void UserInput()
{
    Console.SetCursorPosition(5, 15);
    Console.WriteLine("Tryk på en af de følgende taster: E, F, C, A, T, S, Q");
    Console.SetCursorPosition(5, 16);
    string sBrugerIndtastning = Console.ReadLine();
    do
{
    Console.SetCursorPosition(5, 14);
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
            if (sCIndtastning != "")
            {
                // køn og alder som afventer
                Console.SetCursorPosition(11, 9);
                Console.Write("Afventer");
                Console.SetCursorPosition(13, 7);
                Console.Write("Afventer");
            }
            else
            {
                Console.Write("");
            }
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
        Console.SetCursorPosition(5, 14);
        Console.WriteLine("Ukendt input");
    }

        Console.SetCursorPosition(5, 14);
        sBrugerIndtastning = Console.ReadLine();
    } while (sBrugerIndtastning != "Q");
}
//fra opgave 6.7
static void DrawBoxAround() 
{
    //ekstra linje tilføjet.
    Console.SetCursorPosition(5, 17);
    int userBoxes = 0;
    Console.Write("Please type number of wished boxes --> ");
    string sUserAnswer = Console.ReadLine();
    int iUserAnswer = Convert.ToInt32(sUserAnswer);
    Console.SetCursorPosition(5, 18);
    Console.Write("Please type how much smaller each box should be in increments --> ");
    string sUserBoxSizeWish = Console.ReadLine();
    int iUserBoxSize = Convert.ToInt32(sUserBoxSizeWish);
    int xstart = 1;
    int xstop = 100;
    int ystart = 1;
    int ystop = 25;
    while (userBoxes < iUserAnswer)
    {
        makeThreeBoxes(xstart, xstop, ystart, ystop);
        userBoxes = userBoxes + 1;
        xstart = xstart + iUserBoxSize;
        xstop = xstop - iUserBoxSize;
        ystart = ystart + iUserBoxSize;
        ystop = ystop - iUserBoxSize;
        //6.5
    }


    static void makeThreeBoxes(int xstart, int xstop, int ystart, int ystop)
    {
        //ogpave 4.5
        int x = xstart;
        int y = ystart;
        Console.SetCursorPosition(x, y);
        int sleeper = 10;
        Console.Write("╔");

        while (x < xstop)
        {
            //4.4 part 1
            Thread.Sleep(sleeper);
            x = x + 1;
            Console.SetCursorPosition(x, y);
            Console.Write("═");
        }

        x = x + 1;
        Console.Write("╗");

        while (y < ystop)
        {
            //4.4 part 1
            Thread.Sleep(sleeper);
            Console.SetCursorPosition(x, y + 1);
            Console.Write("║");
            y = y + 1;
        }

        y = ystop + 1;
        Console.SetCursorPosition(x, y);
        Console.Write("╝");

        while (x > xstart)
        {
            //4.4 part 1
            Thread.Sleep(sleeper);
            x = x - 1;
            Console.SetCursorPosition(x, y);
            Console.Write("═");
        }


        Console.SetCursorPosition(x, y);
        Console.Write("╚");


        while (y > ystart + 1)
        {
            //4.4 part 1
            Thread.Sleep(sleeper);
            Console.SetCursorPosition(x, y - 1);
            Console.Write("║");
            y = y - 1;
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

    Console.ReadKey();
    Console.SetCursorPosition(0, 110);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
*/
//opgave 7.14 gjort til kommentar for at løse næste opgave.

//opgave 2.5
/*
using Microsoft.Win32.SafeHandles;
using System.Security.Cryptography.X509Certificates;
*/

using System;

DrawScreen();
UserInput();
//9.7 ny metode
kønFraCpr();
//9.7 ny metode slutning
DrawBoxAround();

static void DrawScreen()
{
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
}
static void UserInput()
{
    Console.SetCursorPosition(5, 15);
    Console.WriteLine("Tryk på en af de følgende taster: E, F, C, A, T, S, Q");
    Console.SetCursorPosition(5, 16);
    string sBrugerIndtastning = Console.ReadLine();
    do
{
    Console.SetCursorPosition(5, 14);
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
            /* // fra originale opgave fjernet grundet dette skulle udskfites.
     if (sCIndtastning != "")
     {
         // køn og alder som afventer
         Console.SetCursorPosition(11, 9);
         Console.Write("Afventer");
         Console.SetCursorPosition(13, 7);
         Console.Write("Afventer");
     }
     */
            //køn tilføjet.
            kønFraCpr();
            
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
        Console.SetCursorPosition(5, 14);
        Console.WriteLine("Ukendt input");
    }

        Console.SetCursorPosition(5, 14);
        sBrugerIndtastning = Console.ReadLine();
    } while (sBrugerIndtastning != "Q");
}
//fra opgave 6.7

//bestem hvor boxe skal være metode.
static void DrawBoxAround() 
{
    //ekstra linje tilføjet.
    Console.SetCursorPosition(5, 17);
    int userBoxes = 0;
    Console.Write("Please type number of wished boxes --> ");
    string sUserAnswer = Console.ReadLine();
    int iUserAnswer = Convert.ToInt32(sUserAnswer);
    Console.SetCursorPosition(5, 18);
    Console.Write("Please type how much smaller each box should be in increments --> ");
    string sUserBoxSizeWish = Console.ReadLine();
    int iUserBoxSize = Convert.ToInt32(sUserBoxSizeWish);
    int xstart = 1;
    int xstop = 100;
    int ystart = 1;
    int ystop = 25;
    while (userBoxes < iUserAnswer)
    {
        makeThreeBoxes(xstart, xstop, ystart, ystop);
        userBoxes = userBoxes + 1;
        xstart = xstart + iUserBoxSize;
        xstop = xstop - iUserBoxSize;
        ystart = ystart + iUserBoxSize;
        ystop = ystop - iUserBoxSize;
        //6.5
    }

    //lav boxe metode.
    static void makeThreeBoxes(int xstart, int xstop, int ystart, int ystop)
    {
        //ogpave 4.5
        int x = xstart;
        int y = ystart;
        Console.SetCursorPosition(x, y);
        int sleeper = 10;
        Console.Write("╔");

        while (x < xstop)
        {
            //4.4 part 1
            Thread.Sleep(sleeper);
            x = x + 1;
            Console.SetCursorPosition(x, y);
            Console.Write("═");
        }

        x = x + 1;
        Console.Write("╗");

        while (y < ystop)
        {
            //4.4 part 1
            Thread.Sleep(sleeper);
            Console.SetCursorPosition(x, y + 1);
            Console.Write("║");
            y = y + 1;
        }

        y = ystop + 1;
        Console.SetCursorPosition(x, y);
        Console.Write("╝");

        while (x > xstart)
        {
            //4.4 part 1
            Thread.Sleep(sleeper);
            x = x - 1;
            Console.SetCursorPosition(x, y);
            Console.Write("═");
        }


        Console.SetCursorPosition(x, y);
        Console.Write("╚");


        while (y > ystart + 1)
        {
            //4.4 part 1
            Thread.Sleep(sleeper);
            Console.SetCursorPosition(x, y - 1);
            Console.Write("║");
            y = y - 1;
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

    Console.ReadKey();
    Console.SetCursorPosition(0, 110);
}

//ny tilføjelse til 9.7 start
//erstat køn afventer med k for kvinde og m for mand. ullige tal mand lige tal kvinde.
//køn metode til cpr.
static void kønFraCpr()
{
    string sCIndtastning = Console.ReadLine();
    char cCIndtastning = sCIndtastning[sCIndtastning.Length - 1];
    string sCIndtastningNy = Convert.ToString(cCIndtastning);
    //ny linje tilføjet til opgave 9.7
    if (sCIndtastningNy == "1" || sCIndtastningNy == "3" || sCIndtastningNy == "5" || sCIndtastningNy == "7" || sCIndtastningNy == "9")
    {
        Console.SetCursorPosition(11, 9);
        Console.Write("M");
        Console.SetCursorPosition(5, 14);
    }
    else if (sCIndtastningNy == "0" || sCIndtastningNy == "2" || sCIndtastningNy == "4" || sCIndtastningNy == "6" || sCIndtastningNy == "8")
    {
        Console.SetCursorPosition(11, 9);
        Console.Write("K");
        Console.SetCursorPosition(5, 14);
    }
    //ny linje tilføjet til opgave 9.7 slut
    else
    {
        Console.Write("");
    }
    alderFraCpr(sCIndtastning);
}
//ny tilføjelse til 9.7 slut

//endnu en ny tilføjelse 9.7 for alder metode.
static void alderFraCpr(string sCIndtastning) 
{
    int iNuværendeDato = 23;
    char cCIndtastningCprÅrEt = sCIndtastning[4];
    char cCIndtastningCprÅrTo = sCIndtastning[5];
    string sCIndtastningCprÅrEt = Convert.ToString(cCIndtastningCprÅrEt);
    string scAIndtastningCprÅrTo = Convert.ToString(cCIndtastningCprÅrTo);
    string sBrugerFødt = sCIndtastningCprÅrEt + scAIndtastningCprÅrTo;
    int iBrugerFødt = Convert.ToInt32(sBrugerFødt);
    int brugerAlder = iNuværendeDato - iBrugerFødt;
    if (sCIndtastning != "")
    {
        Console.SetCursorPosition(13, 7);
        Console.Write(brugerAlder);
    }
    else 
    {
        Console.Write("2");
    }
}



//endnu en ny tilføjelse 9.7 for alder metode slutning.

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

//ikke sikker på hvorfor dette ikke virker. måske noget med det skal være en string? derudover måske noget med beregningen af alderen der er forkert. jeg føler dog køn delen virker.