// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//opgave 7.1
/*
 svar: der er ikke noget output da der ikke er angivet en værdi ved eksemplet endnu. Da dette kræver et user input. Dog de mulige output kan være følgende:
hvis moterSize er = 4 eller størrere end 4 så vil outputtet i konsollen være: bilen er meget stor.
hvis moterSize er = 2 eller størrere end 2 så vil outputtet i konsollen være: bilen er stor.
hvis moterSize er = 1 eller størrere end 1 så vil outputtet i konsollen være: bilen er mellemstor.
hvis intet af dette passer og dermed tallet for moterSize er mindre end 1 så vil outputtet i konsollen være: "Bilen er ikke stor"
 */

//opgave 7.2 gjort til kommentar for at lave næste opgave.
/*
Console.Write("Angiv motorerens størrelse med 1 tal i liter -> ");
string sMotorstørrelse = Console.ReadLine();
double dMotorstørrelse = Convert.ToDouble(sMotorstørrelse);
Console.Write("Angiv bilens pris med tal i dk. Uden ord eller bogstaver. -> ");
string sBilNyPris = Console.ReadLine();
double dBilNyPris = Convert.ToDouble(sBilNyPris);
int afgift = 0;
if (dMotorstørrelse > 3)
{
    Console.Write("Afgift: 5% af nypris på bil til " + sBilNyPris + "kr er -> " + (dBilNyPris * 0.05) + "kr");
}
else if (dMotorstørrelse >= 2)
{
    Console.Write("Afgift: 3% af nypris på bil til " + sBilNyPris + "kr er -> " + (dBilNyPris * 0.03) + "kr");
}
else if (dMotorstørrelse < 2)
{
    Console.Write("Afgift: 2% af nypris på bil til " + sBilNyPris + "kr er -> " + (dBilNyPris * 0.02) + "kr");
}
else
{
    Console.Write("Ukendt");
}
*/

//opgave 7.3 gjort til kommentar for at lave næste opgave.
/*
Console.Write("Indtast bilmærke -> ");
string carBrand = Console.ReadLine();
Console.Write("Indtast motorstørrelse i liter -> ");
double motorSize = Convert.ToDouble(Console.ReadLine());
if (motorSize >= 4)
{
    Console.WriteLine("Bilen er meget stor");
    if (carBrand == "Mercedes")
    {
        Console.WriteLine("Du har en blæreøse!");
    }
}
else if (motorSize >= 2)
{
    Console.WriteLine("Bilen er stor");
    if (carBrand == "BMW")
    {
        Console.WriteLine("Har du også brede fælge?");
    }
}
else if (motorSize >= 1)
{
    Console.WriteLine("Bilen er mellemstor");
    if (carBrand == "Fiat")
    {
        Console.WriteLine("Kedelig bil");
    }
}
else
{
    Console.WriteLine("Bilen er ikke stor");
    if (carBrand == "Toyota")
    {
        Console.WriteLine("Økonomisk bil");
    }
}
*/

//opgave 7.4 gjort til kommentar for at lave næste opgave.
/*
Console.Write("Skriv din alder her i hele år uden måneder -> ");
string sAlder = Console.ReadLine();
int iAlder = Convert.ToInt32(sAlder);
if (iAlder > 57)
{
    Console.WriteLine("For gammel");
}
else if (iAlder <= 57)
{
    Console.WriteLine("Ok alder");
}
else
{
    Console.WriteLine("Ukendt");
}
*/

//opgave 7.5 gjort til kommentar for at lave næste opgave.
/*
Console.Write("Skriv din alder her i hele år uden måneder: -> ");
string sAlder = Console.ReadLine();
int iAlder = Convert.ToInt32(sAlder);
Console.Write("Skriv navn her: -> ");
string navn = Console.ReadLine();
if (iAlder > 60)
{
    Console.WriteLine("For gammel");
}
else if (iAlder >= 50)
{
    Console.WriteLine("Ok");
}
else if (iAlder < 50)
{
    Console.WriteLine("For ung");
}
else 
{
    Console.WriteLine("Ukendt");
}
*/

//opgave 7.6 gjort til kommentar for at lave næste opgave.
/*
Console.Write("Skriv brugernavn her: -> ");
string brugernavn = Console.ReadLine();
Console.Write("Skriv password her: -> ");
string password = Console.ReadLine();
if (brugernavn == "ok")
{
    if (password == "ok")
    {
        Console.WriteLine("ok");
    }
    // else staement til ok tilføjet efter hjælp adpusrgt 
    else
    {
        Console.WriteLine("Brugernavn eller password forkert");
    }
}

else
{
    Console.WriteLine("Brugernavn eller password forkert");
}
*/

//opgave 7.7 gjort til kommentar for at lave næste opgave.
/*
string password = "";
Console.Write("Skriv brugernavn her: -> ");
string brugernavn = Console.ReadLine();
if (brugernavn == "ok")
{
    Console.Write("Skriv password her: -> ");
    password = Console.ReadLine();
    if (password == "ok")
    {
        Console.WriteLine("ok");
    }
    // else staement til ok tilføjet efter hjælp adspurgt 
    else
    {
        Console.WriteLine("Brugernavn eller password forkert");
    }
}

else
{
    Console.WriteLine("Brugernavn eller password forkert");
}
*/

//7.8 gjort til kommentar for at lave næste opgave.
//test code for brainstorm
/*
string s24KmKørsel = "Ingen fradrag";
string sMellem25Og100KmKørsel = "154 øre pr km";
string sOver100KmKørsel = "77 øre pr km";
*/
//test code for brainstorm end
/*
int i24KmKørsel = 0;
int iMellem25Og100KmKørsel = 154;
int iOver100KmKørsel = 77;
Console.WriteLine("Fradrags liste:");
Console.WriteLine("Fradrag per km i øre på første 24km -> " + i24KmKørsel + " øre per km");
Console.WriteLine("Fradrag per km i øre på hver km mellem 25-100 -> " + iMellem25Og100KmKørsel + " øre per km");
Console.WriteLine("Fradrag per km i øre på hver km over 100 -> " + iOver100KmKørsel + " øre per km");
Console.Write("Skriv antal km på en pågiven dag i hele tal uden komma her -> ");
string sAntalKm = Console.ReadLine();
int iAntalKm = Convert.ToInt32(sAntalKm);
if (iAntalKm <= 24)
{
    Console.WriteLine("Aktuelle fradrag i alt for " + iAntalKm + "km er: " + (iAntalKm*i24KmKørsel) + " øre");
    double d24KmKørsel = Convert.ToDouble(i24KmKørsel);
    Console.WriteLine("Aktuelle fradrag i alt for " + iAntalKm + "km er: " + (iAntalKm * d24KmKørsel/100) + " kr");
}
else if (iAntalKm >= 25)
{
    Console.WriteLine("Aktuelle fradrag i alt for " + iAntalKm + "km er: " + ((iAntalKm-24) * iMellem25Og100KmKørsel) + " øre");
    double dMellem25Og100KmKørsel = Convert.ToDouble(iMellem25Og100KmKørsel);
    Console.WriteLine("Aktuelle fradrag i alt for " + iAntalKm + "km er: " + ((iAntalKm-24) * dMellem25Og100KmKørsel / 100) + " kr");
}
else if (iAntalKm > 100)
{
    Console.WriteLine("Aktuelle fradrag i alt for " + iAntalKm + "km er: " + ((iAntalKm-24) * iMellem25Og100KmKørsel) + ((iAntalKm-76) * iOver100KmKørsel) + " øre");
    double dOver100KmKørsel = Convert.ToDouble(iOver100KmKørsel);
    Console.WriteLine("Aktuelle fradrag i alt for " + iAntalKm + "km er: " + (((iAntalKm - 24) * iMellem25Og100KmKørsel) + ((iAntalKm - 76) * iOver100KmKørsel) / 100 ) + " kr");
}
else
{
    Console.Write("Ukendt");
}
*/

//7.9 gjort til kommentar for at lave næste opgave.
//hjælp fået
//pris liste
/*
Console.WriteLine("Pris liste:");
int iGæstPris = 0;
Console.WriteLine("Pris per person per overnatning på enkeltværese: 2000kr");
int iEnkeltværelsePris = 2000;
Console.WriteLine("Pris per person per overnatning på dobbeltværelse: 1500kr");
int iDobbeltværelsePris = 1500;
Console.WriteLine("Pris per person per overnatning for extra besøgende på dobbeltværelse: 1000kr");
int iEkstraGæstPris = 1000;
double dPrisForGæstOgAlle = 0;
Console.WriteLine("Ved besøg over 4 overnatninger gives 10% rabat på prisen");
//bruger input
Console.Write("Skriv fornavn her -> ");
string fornavn = Console.ReadLine();
Console.Write("Skriv efternavn her -> ");
string efternavn = Console.ReadLine();
string fuldenavn = efternavn + ", " + fornavn;
Console.Write("Skriv antal gæster her i tal uden bogstaver eller komma -> ");
string sAntalGæster = Console.ReadLine();
int iAntalGæster = Convert.ToInt32(sAntalGæster);
Console.Write("Skriv antal overnatninger her i tal uden bogstaver eller komma -> ");
string sAntalOvernatninger = Console.ReadLine();
int iAntalOvernatninger = Convert.ToInt32(sAntalOvernatninger);
Console.WriteLine("Muligheder for værelser: 'enkeltværelse' eller 'dobbeltværelse'");
Console.Write("Skriv type værelse her uden tal og mellemrum -> ");
string typeVærelse = Console.ReadLine();
//output
Console.WriteLine("Tilbud til " + fuldenavn);
//if else statements.
if (typeVærelse == "enkeltværelse")
{
    iGæstPris = (iEnkeltværelsePris * iAntalGæster) + (iEnkeltværelsePris * iAntalOvernatninger);
    Console.WriteLine("Pris: " + iGæstPris + "kr");
    if (iAntalOvernatninger > 4) 
    {
        double dGæstPris = Convert.ToDouble(iGæstPris);
        dGæstPris = dGæstPris * 0.9;
        Console.WriteLine("Efter rabat pga over 4 overnatninger: " + dGæstPris + "kr");
    }
}
else if (typeVærelse == "dobbeltværelse")
{
    int testGæstVariabel = iAntalGæster;
    int adv = 0;
    while (testGæstVariabel >= 2)
    {
        adv = adv + 1;
        testGæstVariabel = testGæstVariabel - 2;
    }
    int dobbeltGæster = (testGæstVariabel * 2 * iDobbeltværelsePris);
    int ekstraGæster = (testGæstVariabel * iEkstraGæstPris);
    int alleGæster = dobbeltGæster + ekstraGæster;
    int total = alleGæster * iAntalOvernatninger;
    Console.WriteLine("Pris: " + (alleGæster * iAntalOvernatninger) + "kr");
    if (iAntalGæster < 2) 
    {
        iEkstraGæstPris = iEkstraGæstPris * iAntalOvernatninger;
        Console.WriteLine("Pris for ekstra gæst i alt for alle overnatninger: " + iEkstraGæstPris + "kr");
    }
    if (iAntalOvernatninger > 4)
    {
       
        Console.WriteLine("Inden rabat: " + total + "kr");
        double dTotal = Convert.ToDouble(total);
        double rabatTotal = dTotal * 0.9;
        Console.WriteLine("Efter rabat pga over 4 overnatninger: " + rabatTotal + "kr");
    }
}
else 
{
    Console.Write("Ukendt");
}

//evt ret så prisen der udregnes med ekstra brugere er rigtig.
*/

//opgave 7.10 gjort til kommentar for at løse næste opgave.
/*
string sKørProgramIgen = "";
do {
    Console.WriteLine("Du skal en tur til Tyskland efter billige bajere sammen med din kammerat. I kører i en lyserød Yaris der max. må laste 475 kg inklusiv personer.");
    Console.Write("Vægten af dig i kilo med eller uden decimal tal -> ");
    string sEgenVægt = Console.ReadLine();
    double dEgenVægt = Convert.ToDouble(sEgenVægt);
    Console.Write("Vægten af din kammerat i kilo med eller uden decimal tal -> ");
    string sKammeratVægt = Console.ReadLine();
    double dKammeratVægt = Convert.ToDouble(sKammeratVægt);
    double dNyttevægt = dEgenVægt + dKammeratVægt;
    Console.WriteLine("Nyttevægt -> " + (475 - dNyttevægt));
    Console.Write("En ramme øl vejer 8.5 kilo. Indtast ønsket antal rammer af øl i hele tal uden komma. -> ");
    string sAntalRammerØl = Console.ReadLine();
    double dAntalRammerØl = Convert.ToDouble(sAntalRammerØl);
    double dØlProcentAfNyttevægt = (dAntalRammerØl * 8.5 * 100) / dNyttevægt;
    Console.WriteLine(dØlProcentAfNyttevægt + "% af bil max last brugt");
    if (dØlProcentAfNyttevægt > 100)
    {
        Console.WriteLine("I kan ikke have så mange rammer med.");
    }
    else if (dØlProcentAfNyttevægt >= 90)
    {
        Console.WriteLine("Pas på, I er tæt på vægtgrænsen.");
    }
    else if (dØlProcentAfNyttevægt >= 70)
    {
        Console.WriteLine("Husk at sætte dæktrykket lidt op og justere forlygterne lidt ned.");
    }
    else if (dØlProcentAfNyttevægt >= 30)
    {
        Console.WriteLine("God tur");
    }
    else if (dØlProcentAfNyttevægt < 30)
    {
        Console.WriteLine("Er du sikker på det kan betale sig at køre efter så lidt?");
    }
    else
    {
        Console.WriteLine("Den mængde af bajere kender jeg ikke der er måske sket en fejl.");
    }
    Console.Write("Ønsker du at køre programmet igen? Ja/Nej? -> ");
    sKørProgramIgen = Console.ReadLine();
} while (sKørProgramIgen == "Ja");
*/

//opgave 7.11 gjort til kommentar for at løse næste opgave.
/*
Console.WriteLine("Du kører i en bil.");
Console.Write("Indtast hastighedsbegrænsing (tilladt fart.) -> ");
string sHastighedsbegrænsing = Console.ReadLine();
double dHastighedsbegrænsing = Convert.ToDouble(sHastighedsbegrænsing);
Console.Write("Indtast aktuelle fart -> ");
string sAktuelleFart = Console.ReadLine();
double dAktuelleFart = Convert.ToDouble(sAktuelleFart);
// formel til udregning af overskridelse i procent.
double dOverskridelseIProcent = ((dAktuelleFart - dHastighedsbegrænsing) * 100) / dHastighedsbegrænsing;
Console.WriteLine("Overskridelse: " + dOverskridelseIProcent + "%");
if (dOverskridelseIProcent < 10)
{
    Console.WriteLine(500 + "kr");
}
else if (dOverskridelseIProcent <= 30)
{
    Console.WriteLine(2000 + "kr");
}
else if (dOverskridelseIProcent < 50)
{
    Console.WriteLine(5000 + "kr");
    Console.WriteLine("Et klip i kørekortet");
}
else if (dOverskridelseIProcent >= 50) 
{
    Console.WriteLine(8000 + "kr");
    Console.WriteLine("Betinget frakendelse af kørekortet");
}
*/

//opgave 7.12 gjort til kommentar for at løse næste opgave.
/*
Console.Write("Indtast båd længde i fod -> ");
string sBådLængdeIFod = Console.ReadLine();
double dBådLængdeIFod = Convert.ToDouble(sBådLængdeIFod);
double dBådLængdeIMeter = dBådLængdeIFod * 0.3138;
double dHavneAfgift = 0;
Console.WriteLine("Båd længden i meter er: " + dBådLængdeIMeter + " meter");
if (dBådLængdeIMeter <= 4.71)
{
    dHavneAfgift = 50;
    Console.WriteLine("Prisen for at ligge til havn for en båd med længden " + dBådLængdeIMeter + " meter er " + dHavneAfgift + " kr");
}
else if (dBådLængdeIMeter <= 6.28)
{
    dHavneAfgift = 75;
    Console.WriteLine("Prisen for at ligge til havn for en båd med længden " + dBådLængdeIMeter + " meter er " + dHavneAfgift + " kr");
}
else if (dBådLængdeIMeter <= 10.05)
{
    dHavneAfgift = 100;
    Console.WriteLine("Prisen for at ligge til havn for en båd med længden " + dBådLængdeIMeter + " meter er " + dHavneAfgift + " kr");
}
else if (dBådLængdeIMeter <= 13.18)
{
    dHavneAfgift = 150;
    Console.WriteLine("Prisen for at ligge til havn for en båd med længden " + dBådLængdeIMeter + " meter er " + dHavneAfgift + " kr");
}
else if (dBådLængdeIMeter > 13.18)
{
    dHavneAfgift = 250;
    Console.WriteLine("Prisen for at ligge til havn for en båd med længden " + dBådLængdeIMeter + " meter er " + dHavneAfgift + " kr");
}
else
{
    Console.WriteLine("Ukendt værdi");
}
Console.Write("Ønskes der en beregning mere? ja/nej -> ");
string sØnskesEnBeregningMere = Console.ReadLine();
if (sØnskesEnBeregningMere == "ja")
{
    Console.WriteLine("Er båden en moterbåd eller sejlbåd? moterbåd/sejlbåd -> ");
    string sMoterbådEllerSejlbåd = Console.ReadLine();
    if (sMoterbådEllerSejlbåd == "moterbåd")
    {
        Console.Write("Prisen for at ligge til havn for en moterbåd er højere end en sejlbåd og dermed er den nye pris: ");
        Console.WriteLine(dHavneAfgift * 1.20 + "kr");
    }
    else 
    {
        Console.Write("");
    }
}
else if (sØnskesEnBeregningMere == "nej")
{
    Console.Write("");
}
else 
{
    Console.WriteLine("Fejl. Ukendt svar.");
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

//opgave 7.15

menu();
brugerindtastning();

static void menu() 
{
    Console.WriteLine("Areal beregner");
    Console.WriteLine("Dette program kan beregne arealet af en af nedstående former:");
    Console.WriteLine("kvadrat: 1");
    Console.WriteLine("trekant: 2");
    Console.WriteLine("rektangel: 3");
}

static void brugerindtastning()
{
    Console.Write("Skriv tallet på formen man ønsker at udregne arealet på her (1/2/3) -> ");
    string sBrugerSvar = Console.ReadLine();
    double dBrugerSvar = Convert.ToDouble(sBrugerSvar);
    double arealAfKvadrat = 0;
    double arealAfTrekant = 0;
    double arealAfRektangel = 0;
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
    else 
    {
        Console.WriteLine("Ikke en kendt svar mulighed");
    }
    resultatOutput(arealAfKvadrat, arealAfTrekant, arealAfRektangel, dBrugerSvar);
}

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

static void resultatOutput(double arealAfKvadrat, double arealAfTrekant, double arealAfRektangel, double dBrugerSvar)
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
    else 
    {
        Console.WriteLine("Error");
    }
}
