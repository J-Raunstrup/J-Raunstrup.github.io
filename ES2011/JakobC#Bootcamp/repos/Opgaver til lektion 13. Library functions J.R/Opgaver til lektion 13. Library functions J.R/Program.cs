// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//opgave 13.1 gjort til kommentar for at løse næste opgave.
//7.15

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

//opgave 13.2 gjort til kommentar for at løse næste opgave.
/*
tærningsKastProgram();
Console.WriteLine("Skal programmet køre igen? (j/n) ->");
string sSkalProgramKøreIgen = Console.ReadLine();

while (sSkalProgramKøreIgen != "n")
{
    tærningsKastProgram();
    Console.WriteLine("Skal programmet køre igen? (j/n) ->");
    sSkalProgramKøreIgen = Console.ReadLine();
}

static void tærningsKastProgram() 
{
    Console.WriteLine("Ønsker du at kaste en tærning? (j/n) ->");
    string sBrugerSvar = Console.ReadLine();
    Random rand = new Random();
    int iTilfældigtTærningeKast = rand.Next(1, 6);
    if (sBrugerSvar == "j")
    {
        Console.WriteLine("svaret er ja");
        Console.WriteLine(iTilfældigtTærningeKast);
    }
    else if (sBrugerSvar == "n")
    {
        Console.WriteLine("svaret er nej");
    }
    else
    {
        Console.WriteLine("Ukendt svar");
    }
}
*/

//ogpave 13.3 gjort til kommentar for at løse næste opgave.
/*
//menu
Console.WriteLine("skal der kastes med 2 tærninger? (j/n) -> ");

string sBrugerSvar = Console.ReadLine();
//if else der tjekker bruger svar og kører program hvis svar til at kaste 2 tærninger er ja.
if (sBrugerSvar == "j")
{
    //metode til tærninge kast der bruges
    kastToTærninger();
}
else
{
    Console.WriteLine("Program afsluttet");
}



//metode til tærninge kast
static void kastToTærninger() 
{
    //Arrays der skabes
    Random rand = new Random();
    int iTilfældigTærning1 = 0;
    int iTilfældigTærning2 = 0;
    int[] aListeOverFørsteTærningKast = new int[10];
    int[] aListeOverAndenTærningKast = new int[10];

    //loop
    //tærninger der kastes og sættes i en array via et loop.
    for (int i = 0; i < 10; i++)
    {
        iTilfældigTærning1 = rand.Next(1, 6);
        iTilfældigTærning2 = rand.Next(1, 6);
        aListeOverFørsteTærningKast[i] = iTilfældigTærning1;
        aListeOverAndenTærningKast[i] = iTilfældigTærning2;
    }

    //output
    //Første tærningekast output
    Console.WriteLine("Første tærning kast liste: ");
    for (int i = 0; i < aListeOverFørsteTærningKast.Length; i++)
    {
        Console.Write(aListeOverFørsteTærningKast[i]);
    }

    Console.WriteLine();
    //andet tærningekast output
    Console.WriteLine("Anden tærning kast liste: ");

    for (int i = 0; i < aListeOverAndenTærningKast.Length; i++)
    {
        Console.Write(aListeOverAndenTærningKast[i]);
    }
}
*/

//opgave 13.4 gjort til kommentar for at løse næste opgave
/*
int iBrugerSvar = 0;
Random rand = new Random();
int iTilfældigtTal = rand.Next(1, 1000);
Console.WriteLine("Gæt et helt tal mellem 1 og 1000");

//loop der checker bruger svar.
do {
    string sBrugerSvar = Console.ReadLine();
    iBrugerSvar = Convert.ToInt32(sBrugerSvar);
    if (iBrugerSvar == iTilfældigtTal)
    {
        Console.WriteLine("Correct!");
    }
    else if (iBrugerSvar < iTilfældigtTal)
    {
        Console.WriteLine("Det svar er for lavt. Prøv et højere tal.");
    }
    else if (iBrugerSvar > iTilfældigtTal)
    {
        Console.WriteLine("Det svar er for højt. Prøv et lavere tal.");
    }
    else
    {
        Console.WriteLine("Ukendt svar eller udfald");
    }
} while (iBrugerSvar != iTilfældigtTal);
*/

//opgave 13.5 gjort til kommentar for at løse næste opgave
//opgave 13.4
// evt tjek om der skal ændres da det gættede antal svar ikke passer med det reele antal af gæt computeren bruger.
/*
int iBrugerSvar = 0;

Random rand = new Random();
int iComputerGæt = 0;
int iLowerBound = 1;
int iUpperBound = 1000;
iComputerGæt = rand.Next(iLowerBound, iUpperBound);

Console.WriteLine("Skriv et helt tal mellem 1 og 1000 som computeren skal gætte");
string sBrugerSvar = Console.ReadLine();
iBrugerSvar = Convert.ToInt32(sBrugerSvar);
int i = 1000;
int iAntalForsøg = 0;

do {
    i = i / 2;
    iAntalForsøg++;
} while (i > 0);
Console.WriteLine(iAntalForsøg);

//loop der checker computer gæt.
do
{
    i++;
    if (iComputerGæt == iBrugerSvar)
    {
    }
    else if (iComputerGæt < iBrugerSvar)
    {
        Console.WriteLine("Computeren gættede {0} Det svar er for lavt. Den vil prøve et højere tal.", iComputerGæt);
            iLowerBound = iComputerGæt;
            iComputerGæt = rand.Next(iLowerBound, iUpperBound);
        Console.WriteLine(iComputerGæt);
    }
    else if (iComputerGæt > iBrugerSvar)
    {
        Console.WriteLine("Computeren gættede {0} Det svar er for højt. Den vil prøve et lavere tal.", iComputerGæt);
            iUpperBound = iComputerGæt;
            iComputerGæt = rand.Next(iLowerBound, iUpperBound);
        Console.WriteLine(iComputerGæt);
    }
    else
    {
        Console.WriteLine("Ukendt svar eller udfald");
    }
} while (iComputerGæt != iBrugerSvar);


if (iComputerGæt == iBrugerSvar)
{
    Console.WriteLine("Computeren gættede {0}. Det er rigtigt!", iComputerGæt);
    Console.WriteLine("Computeren brugte {0} antal gæt", i);
}
else 
{

}
*/

//opgave 13.6 gjort til kommentar for at løse næste opgave.
//pisse svært.
/*

Random rand = new Random();
//tom array skabes
int[] aListeMedTal = new int[10];
//arrayen udfyldes med værdier. alle sammen -1 som placeholder værdi.
for (int j = 0; j< aListeMedTal.Length; j++)
{
    aListeMedTal[j] = -1;
}

//loop for at checke hver plads og generere en værdi som ikke gentages og sættes på hver pægældende plads.
for (int i = 0; i < aListeMedTal.Length; i++) 
{
    //ved nedestående linje laves en variabel kaldet iVælgTal. Denne variable sættes = et tilfældigt tal = 0 og 9.
    int iVælgTal = rand.Next(0,10);
    //her skabes wet while loop. Der kører så længe tallet fra overstående linje allerede eksisterer i vores array. Dette gøres ved hjælp af metoden NumberAlreadyInarray. Så længde at funktionen er
    //== true. altså den vil blive ved med at finde et nyt tal så længe det tilfældige tal allerede findes i arrayen.
    while((NumberAlreadyInarray(aListeMedTal, iVælgTal)) == true)
    {
        //hernede i loopet vil hver gang loopet er kørt. Vil et nyt tal bliver valgt hver gang.
        iVælgTal = rand.Next(0, 10);
    }

 //ved nedestående linje sættes index pladsen i vores array som plusset op hver gang for loopet har kørt med 1. Her sættes hver pågældende plads = det valgte tilfældigt genererede tal der ikke allerede
 //er i arrayen.
    aListeMedTal[i] = iVælgTal;
    
}

//output loop af tal. her outputtes de værdier der tidligere blev generet og placeret i arrayen.
for (int iNy = 0; iNy < aListeMedTal.Length; iNy++) 
{
    Console.Write(aListeMedTal[iNy] + " ");
}


//her skabes en metode hvor der sættes 2 parametre. Der vil acceptere en integer array og en integer variabel. Andre typer ville ikke kunne accepteres af functionen. grundet det er en function da det
// retunerer en værdi. hvorimod metoder ikke retunerer værdier. alle functioner er metoder. ikke alle metoder er funktioner.
static bool NumberAlreadyInarray(int[] a, int n)
{
    //ved nedestående linje laves en bool variabel kaldet returnValue. den sættes = false.
    bool returnValue = false;
    //her laves et loop som fortsætter med at køre indtil arrayens længde er nået til slut.
    for (int i = 0; i < a.Length; i++) 
    {
        //her skrives at hvis index pladsen i arrayet er = tallet n(parameter til functionen). Så vil den sætte den tidligere bool værdi returnValue = true altså sige at det genrerede tal allerede
        //eksisterer.
        if (a[i] == n)
        {
            returnValue = true;
        }
    }
    //her angives det at functionen retunerer hvorvidt tallet findes eller ej.
    return returnValue;

}
*/

//opgave 13.7 gjort til kommentar for at løse næste opgave

int iBrugerStartBeløb = 100;
int iBrugerBeløb = iBrugerStartBeløb;
int iPrisPerSlotMachineSpil = 1;
string sKørSpilIgen = "";
//tal der ruller på jackpot maskine altså håndtag trækkes.

Console.WriteLine("Nuværende saldo {0}", iBrugerStartBeløb);
Console.Write("Vil du gerne spille på slot maskinen? Det koster 5 mønter for hvert spil (j/n) -> ");
string sSkalDerSpilles = Console.ReadLine();

if (sSkalDerSpilles == "j")
{
    slotMachineSpil(iBrugerBeløb, sKørSpilIgen);
}
else if (sSkalDerSpilles == "n") 
{
    Console.WriteLine("Spillet vil ikke starte da svaret var 'n'. Altså nej");
}
else
{
    Console.WriteLine("Ukendt svar");
}



//metode til slot machine.
static void slotMachineSpil(int iBrugerBeløb, string sKørSpilIgen) 
{
do {
iBrugerBeløb = iBrugerBeløb - 5;
Random rand = new Random();
int iTilfældigtTalEt = rand.Next(0, 3);
int iTilfældigtTalTo = rand.Next(0, 3);
int iTilfældigtTalTre = rand.Next(0, 3);
Console.WriteLine("{0} {1} {2}", iTilfældigtTalEt, iTilfældigtTalTo, iTilfældigtTalTre);

if (iTilfældigtTalEt == iTilfældigtTalTo && iTilfældigtTalTo == iTilfældigtTalTre) 
{
    Console.WriteLine("JACKPOT!!!");
        if (iTilfældigtTalEt == 0)
        {
            Console.WriteLine("Du får 5 mønter!");
            iBrugerBeløb = iBrugerBeløb + 5;
        }
        else if (iTilfældigtTalEt == 1)
        {
            Console.WriteLine("Du får 10 mønter!");
            iBrugerBeløb = iBrugerBeløb + 10;
        }
        else if (iTilfældigtTalEt == 2)
        {
            Console.WriteLine("Du får 15 mønter!");
            iBrugerBeløb = iBrugerBeløb + 15;
        }
        else if (iTilfældigtTalEt == 3)
        {
            Console.WriteLine("Du får 20 mønter!");
            iBrugerBeløb = iBrugerBeløb + 20;
        }
        else
        {

        }
        Console.WriteLine("Nuværende saldo: {0}", iBrugerBeløb);
    }
    else
    {
        Console.WriteLine("Bedre held næste gang");
        Console.WriteLine("Nuværende saldo: {0}", iBrugerBeløb);
    }
    Console.Write("Skal spillet køres igen? (j/n) -> ");
    sKørSpilIgen = Console.ReadLine();
} while (iBrugerBeløb > 0 && sKørSpilIgen != "n" && sKørSpilIgen != "");
    if (sKørSpilIgen == "" || sKørSpilIgen == "n")
    {
        Console.WriteLine("Spillet blev stoppet");
    }
    else 
    {
        
    }
    if (iBrugerBeløb < 5 && sKørSpilIgen == "j")
    {
        Console.WriteLine("Beklager makker. Der er ikke nok mønter til endnu et spil.");
    }
    else 
    {
    
    }
}
