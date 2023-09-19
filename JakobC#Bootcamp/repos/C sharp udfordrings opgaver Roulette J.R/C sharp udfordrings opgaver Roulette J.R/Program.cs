// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//steps
//input
//bruger vises tal liste der kan satset på og vælger et tal at satse på

//udregning
//programmet ruller hjulet og afgører om brugeren har vundet eller ej og hvis brugeren taber trækkes et beløb fra. vinder brugeren så tilføjes et beløb i stedet til deres saldo.

//output
//brugeren får af vide om de har vundet eller ej og oplyses om de har mistet eller tjent penge og deres nye saldo vises. Derefter kunne de spørges om de ville spilles igen.

/*
//input
Console.WriteLine("Velkommen til casino: 'The House Always Wins'.");

int iBrugerStartSaldo = 1000;
int iBrugerNuværendeSaldo = iBrugerStartSaldo;
int[] aIRoulettetal = { 0, 100, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };

Console.WriteLine("Roulettespil");
Console.WriteLine();
Console.WriteLine("Start saldo: " + iBrugerStartSaldo + "kr");
bettingMenu(aIRoulettetal, iBrugerNuværendeSaldo);



//bettingmenu
static void bettingMenu(int[] aIRoulettetal, int iBrugerNuværendeSaldo)
{
    Console.WriteLine("Vælg venligst bettings type:");
    Console.WriteLine("1: Bet på et tal");
    Console.WriteLine("WIP 2: Bet på lige eller ulige tal");
    Console.WriteLine("WIP 3: Bet på sort eller rød");
    Console.WriteLine("WIP");

    Console.Write("Skriv ønsket betting type her -> ");
    string sBettingTypeSvar = Console.ReadLine();

    if (sBettingTypeSvar == "1")
    {
        tilGætPåTalSvar1(aIRoulettetal, iBrugerNuværendeSaldo);
    }
    else if (sBettingTypeSvar == "2")
    {
        tilGætPåTalSvar2(aIRoulettetal, iBrugerNuværendeSaldo);
    }
    else
    {
        Console.WriteLine("Programmet stoppes.");
    }
}



//svar mulighed 1 ved menu udfald tekst.
static void tilGætPåTalSvar1(int[] aIRoulettetal, int iBrugerNuværendeSaldo)
{
    Console.WriteLine("Tal liste: ");
    for (int i = 0; i < aIRoulettetal.Length; i++)
    {
        Console.Write(aIRoulettetal[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();

    do
    {
        Console.Write("Skriv et tal at satse på. -> ");
        string sBrugerSatserPå = Console.ReadLine();
        int iBrugerSatserPå = Convert.ToInt32(sBrugerSatserPå);

        Console.Write("Skriv hvor meget der ønskes at sates på tallet " + iBrugerSatserPå + " i kr -> ");
        string sBrugerBeløbSats = Console.ReadLine();
        int iBrugerBeløbSats = Convert.ToInt32(sBrugerBeløbSats);

        Console.WriteLine("Du har satset " + sBrugerBeløbSats + "kr på tallet: " + iBrugerSatserPå);
        Console.WriteLine();
        Console.Write("Alle ods er modtaget og hjulet vil begynde at rulle. Resultatet blev: ");

        iBrugerNuværendeSaldo = rouletteSpinner(iBrugerNuværendeSaldo, iBrugerBeløbSats, iBrugerSatserPå, aIRoulettetal);


    } while (spiligen().ToLower() == "j");
}



static void tilGætPåTalSvar2(int[] aIRoulettetal, int iBrugerNuværendeSaldo)
{
    Console.WriteLine("Der blev valgt lige eller ulige tal som bettingstype.");
    Console.WriteLine("Tal liste: ");
    for (int i = 0; i < aIRoulettetal.Length; i++)
    {
        Console.Write(aIRoulettetal[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();

    do
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1 = uLige");
        Console.WriteLine("2 = lige");
        Console.Write("Ønskes der at satses på lige eller ulige tal? (1/2) -> ");
        string sBrugerSatserPå = Console.ReadLine();
        int iBrugerSatserPå = Convert.ToInt32(sBrugerSatserPå);
        if (iBrugerSatserPå == 1)
        {
            sBrugerSatserPå = "Ulige";
        }
        else if (iBrugerSatserPå == 2)
        {
            sBrugerSatserPå = "lige";
        }
        else
        {
            Console.WriteLine("Error.");
        }

        Console.Write("Skriv hvor meget der ønskes at satses på " + sBrugerSatserPå + " tals gruppen i kr -> ");
        string sBrugerBeløbSats = Console.ReadLine();
        int iBrugerBeløbSats = Convert.ToInt32(sBrugerBeløbSats);

        Console.WriteLine("Du har satset " + sBrugerBeløbSats + "kr på tal gruppen: " + sBrugerSatserPå + " tal");
        Console.WriteLine();
        Console.Write("Alle ods er modtaget og hjulet vil begynde at rulle. Resultatet blev: ");

        iBrugerNuværendeSaldo = rouletteSpinner(iBrugerNuværendeSaldo, iBrugerBeløbSats, iBrugerSatserPå, aIRoulettetal);


    } while (spiligen().ToLower() == "j");
}



//udregning
static int rouletteSpinner(int iBrugerNuværendeSaldo, int iBrugerBeløbSats, int iBrugerSatserPå, int[] aIRoulettetal) 
{
    Random rand = new Random();
    int random1 = rand.Next(0, 37);
    int iFindTalPåRandomPlads = random1;

    Console.WriteLine(aIRoulettetal[iFindTalPåRandomPlads]);
    //spørg jakob om dette gør noget eller er fint.

    if (aIRoulettetal[iFindTalPåRandomPlads] == iBrugerSatserPå)
    {
        iBrugerNuværendeSaldo = iBrugerNuværendeSaldo + (iBrugerBeløbSats * 35);
        Console.WriteLine("VINDER!");
        Console.WriteLine("Der blev gevinst og saldoen er opdateret");
        Console.WriteLine("Nuværende saldo: " + iBrugerNuværendeSaldo + "kr");
    }
    else if (aIRoulettetal[iFindTalPåRandomPlads] != iBrugerSatserPå)
    {
        iBrugerNuværendeSaldo = iBrugerNuværendeSaldo - iBrugerBeløbSats;
        Console.WriteLine("Der blev tabt og saldoen er opdateret");
        Console.WriteLine("Nuværende saldo: " + iBrugerNuværendeSaldo + "kr");
    }
    else
    {
        Console.WriteLine("fejl");
    }
    return iBrugerNuværendeSaldo;
}



//output
static string spiligen()
{
    Console.Write("Ønskes der at spilles igen? (J/N) -> ");
    string sSpilIgenBrugerSvar = Console.ReadLine();

    if (sSpilIgenBrugerSvar == "j" || sSpilIgenBrugerSvar == "J")
    {
        Console.WriteLine("Spillet startes igen.");
        Console.WriteLine();
        //skriv repeat af metode her.
    }
    else if (sSpilIgenBrugerSvar == "n" || sSpilIgenBrugerSvar == "N")
    {
        Console.WriteLine("Spillet stoppes.");
    }
    else
    {
        Console.WriteLine("fejl");
    }
    return sSpilIgenBrugerSvar;
}




//enkelt tal bet. done. godkendt af jakob.

//ulige og lige tal
//ulige tal mangler at have roulettecheckerne rettet så den kører efter tal. det kan måske gøres med et if else statement. så hvis tal type er = 1 så skal tallet fra rouletten
//være 1 eller 3 eller 5 osv osv.

//sort eller rød bet

//først ulige tal. så farver. Banken vinder altid på 0 eller 00. uanset hvad.

//egen ide. evt sørg for man ikke kan bette på 100 og 0 da det er husets tal. Dog bare en ide. Ikke nødvendigt. måske først relevant til sidst.
//evt sørg for at når man har lavet en bet at man kan bette på noget nyt og ikke skal køre med samme bet type. så f.eks. hvis man har bettet på røde tal. så vil man gern ekunne skifte
//til at kunne bette på et tal som f.eks. 1. frem for at man er bundet til kun at køre med farve bets.
*/









//input
Console.WriteLine("Velkommen til casino: 'The House Always Wins'.");

int iBrugerStartSaldo = 1000;
int iBrugerNuværendeSaldo = iBrugerStartSaldo;

Console.WriteLine("Roulettespil");
Console.WriteLine();
Console.WriteLine("Start saldo: " + iBrugerStartSaldo + "kr");

//vis brugeren listen med betting muligheder
bettingMenu();

//gør at roulettetals listen kan læses af alle metoder hvis nødvendigt.
int[] aRoulettetal = aRouletteTalListe();

//tag imod brugerens ønskede bettings type.
ønsketBettingType(aRoulettetal, iBrugerNuværendeSaldo);

//find tilfældigt tal
int iFindTalPåRandomPlads = skabRandomTal(aRoulettetal);



//bettingmenu. lister betting muligheder for bugeren.
static void bettingMenu()
{
    Console.WriteLine("Vælg venligst bettings type:");
    Console.WriteLine("1: Bet på et tal");
    Console.WriteLine("WIP 2: Bet på lige eller ulige tal");
    Console.WriteLine("WIP 3: Bet på sort eller rød");
    Console.WriteLine("WIP");
}



static int[] aRouletteTalListe()
{
    int[] aRoulettetal = { 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
    return aRoulettetal;
}



static void aRouletteTalListeViser(int[] aRoulettetal)
{
    Console.WriteLine("Tal liste: ");
    for (int i = 0; i < aRoulettetal.Length; i++)
    {
        Console.Write(aRoulettetal[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}



//tager imod brugerens ønskede bettingstype
static void ønsketBettingType(int[] aRoulettetal, int iBrugerNuværendeSaldo) 
{
    Console.Write("Skriv ønsket betting type her -> ");
    string sBettingTypeSvar = Console.ReadLine();
    
    //hvis betting type er på et tal.
    if (sBettingTypeSvar == "1")
    {
        aRouletteTalListeViser(aRoulettetal);
        type1Bets(aRoulettetal, iBrugerNuværendeSaldo);
    }
    //hvis betting type er på gruppen med lige eller ulige tal
    else if (sBettingTypeSvar == "2")
    {
        aRouletteTalListeViser(aRoulettetal);
        type2Bets(aRoulettetal, iBrugerNuværendeSaldo);
    }
    //standard svar hvis ingen svar genkendes.
    else
    {
        Console.WriteLine("Programmet stoppes.");
    }
}



//svar mulighed 1 ved menu udfald tekst.
static void type1Bets(int[] aIRoulettetal, int iBrugerNuværendeSaldo)
{

    do
    {
        Console.Write("Skriv et tal at satse på. -> ");
        string sBrugerSatserPå = Console.ReadLine();
        int iBrugerSatserPå = Convert.ToInt32(sBrugerSatserPå);

        Console.Write("Skriv hvor meget der ønskes at sates på tallet " + iBrugerSatserPå + " i kr -> ");
        string sBrugerBeløbSats = Console.ReadLine();
        int iBrugerBeløbSats = Convert.ToInt32(sBrugerBeløbSats);

        Console.WriteLine("Du har satset " + sBrugerBeløbSats + "kr på tallet: " + iBrugerSatserPå);
        Console.WriteLine();
        Console.Write("Alle ods er modtaget og hjulet vil begynde at rulle. Resultatet blev: ");

        //hvad gør dette?
        iBrugerNuværendeSaldo = rouletteSpinner(iBrugerNuværendeSaldo, iBrugerBeløbSats, iBrugerSatserPå, aIRoulettetal);


    } while (startSpilIgen().ToLower() == "j");
}



static void type2Bets(int[] aIRoulettetal, int iBrugerNuværendeSaldo)
{
    Console.WriteLine("Der blev valgt lige eller ulige tal som bettingstype.");

    do
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1 = uLige");
        Console.WriteLine("2 = lige");
        Console.Write("Ønskes der at satses på lige eller ulige tal? (1/2) -> ");
        string sBrugerSatserPå = Console.ReadLine();
        int iBrugerSatserPå = Convert.ToInt32(sBrugerSatserPå);
        if (iBrugerSatserPå == 1)
        {
            sBrugerSatserPå = "Ulige";
        }
        else if (iBrugerSatserPå == 2)
        {
            sBrugerSatserPå = "lige";
        }
        else
        {
            Console.WriteLine("Error.");
        }

        Console.Write("Skriv hvor meget der ønskes at satses på " + sBrugerSatserPå + " tals gruppen i kr -> ");
        string sBrugerBeløbSats = Console.ReadLine();
        int iBrugerBeløbSats = Convert.ToInt32(sBrugerBeløbSats);

        Console.WriteLine("Du har satset " + sBrugerBeløbSats + "kr på tal gruppen: " + sBrugerSatserPå + " tal");
        Console.WriteLine();
        Console.Write("Alle ods er modtaget og hjulet vil begynde at rulle. Resultatet blev: ");

        iBrugerNuværendeSaldo = rouletteSpinner(iBrugerNuværendeSaldo, iBrugerBeløbSats, iBrugerSatserPå, aIRoulettetal, iFindTalPåRandomPlads);

    } while (startSpilIgen().ToLower() == "j");
}



static int skabRandomTal(int[] aRoulettetal)
{
    Random rand = new Random();
    int random1 = rand.Next(0, 37);
    int iFindTalPåRandomPlads = aRoulettetal[random1];

    Console.WriteLine();
    Console.WriteLine("Roulletten landede på : {0}", iFindTalPåRandomPlads);
    return iFindTalPåRandomPlads;
}



//udregning
static int rouletteSpinner(int iBrugerNuværendeSaldo, int iBrugerBeløbSats, int iBrugerSatserPå, int[] aRoulettetal, int iFindTalPåRandomPlads)
{

    //spørg jakob om dette gør noget eller er fint.

    if (aRoulettetal[iFindTalPåRandomPlads] == iBrugerSatserPå)
    {
        iBrugerNuværendeSaldo = iBrugerNuværendeSaldo + (iBrugerBeløbSats * 35);
        Console.WriteLine("VINDER!");
        Console.WriteLine("Der blev gevinst og saldoen er opdateret");
        Console.WriteLine("Nuværende saldo: " + iBrugerNuværendeSaldo + "kr");
    }
    else if (aRoulettetal[iFindTalPåRandomPlads] != iBrugerSatserPå)
    {
        iBrugerNuværendeSaldo = iBrugerNuværendeSaldo - iBrugerBeløbSats;
        Console.WriteLine("Der blev tabt og saldoen er opdateret");
        Console.WriteLine("Nuværende saldo: " + iBrugerNuværendeSaldo + "kr");
    }
    else
    {
        Console.WriteLine("fejl");
    }
    return iBrugerNuværendeSaldo;
}



//output
static string startSpilIgen()
{
    Console.Write("Ønskes der at spilles igen? (J/N) -> ");
    string sSpilIgenBrugerSvar = Console.ReadLine();

    if (sSpilIgenBrugerSvar == "j" || sSpilIgenBrugerSvar == "J")
    {
        Console.WriteLine("Spillet startes igen.");
        Console.WriteLine();
        //skriv repeat af metode her.
    }
    else if (sSpilIgenBrugerSvar == "n" || sSpilIgenBrugerSvar == "N")
    {
        Console.WriteLine("Spillet stoppes.");
    }
    else
    {
        Console.WriteLine("fejl");
    }
    return sSpilIgenBrugerSvar;
}