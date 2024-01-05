// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//globale variabler. start beløb. beløb. liste med tal. resultat udfald.


//menu

//input

//bruger bet type

//bruger bet underype. f.eks. tal. lige. ulige osv.

//bruger bet beløb

//random tal på spin.

//saldo opdaterer

//spil igen



int startSaldo = 1000;

int saldo = startSaldo;

//int[] listeMedTal = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
//tilføj pladser eller tal.

Console.WriteLine("Velkommen til casino 'The House Always Wins' siger en mand ved indgangen.");
Console.WriteLine("Der bliver gået lidt fremad. Roulette maskinen kalder på dig. 'Spil på mig'");
Console.WriteLine("Fristet af stemmen bevæges der hen imod roulette maskinen. Her ses en skærm hvor man kan vælge en ønsket betting type.");
Console.WriteLine();


do
{
    string tagImodBetType = bettingMenu();

    int[] listeMedTal = modtagBetType(tagImodBetType);

    int variabelTilModtagBetBeløb = modtagBetBeløb(saldo);

    int tilfældigtTal = returnEtTilfældigtTal();

    bool gevinstEllerEj = sammenlignTilfældigttalMedBrugerBet(listeMedTal, tilfældigtTal);

    int variabelTilGevinstUdregning = beregnGevinst(gevinstEllerEj, tagImodBetType, variabelTilModtagBetBeløb);

    saldo = opdaterSaldo(saldo, variabelTilGevinstUdregning);
} while (spilIgen(saldo) != false);



static string bettingMenu() 
{
    //vis liste med bettingstyper. med 1 tal foran hver mulighed der tilsvarer til hver mulighed.
    Console.WriteLine("Betting menu");
    Console.WriteLine("Vælg venligst bet type nedeunder");
    Console.WriteLine("1: Gruppen med røde tal");
    Console.WriteLine("2: Gruppen med sorte tal");
    Console.WriteLine("3: Gruppen med tal 1 til 18");
    Console.WriteLine("4: Gruppen med tal 19 til 36");
    Console.WriteLine("5: Gruppen med ulige tal");
    Console.WriteLine("6: Gruppen med lige tal");
    Console.WriteLine("7: Et enkelt tal");
    Console.WriteLine();
    Console.Write("Skriv venligst svar her (1/2/3/4/5/6/7) -> ");

    string tagImodBetType = Console.ReadLine();
    return tagImodBetType;
}

static int modtagBetBeløb(int saldo)
{
    //modtag indtastning. gør det til int. derefter retuner.
    Console.Write("Hvor meget skal der spilles for? Maks beløb er {0}. -> ", saldo);
    string brugerBetBeløb = Console.ReadLine();
    Console.WriteLine();
    int brugerBetBeløbInt = Convert.ToInt32(brugerBetBeløb);
    if (brugerBetBeløbInt > saldo)
    {
        Console.WriteLine("Bet beløbet på {0} kan der ikke bettes for da det overskrider saldoens beløb på {1}.", brugerBetBeløbInt, saldo);
        return 0;
    }
    else 
    {
        Console.WriteLine("Betten på {0} er modtaget.", brugerBetBeløbInt);
        Console.WriteLine("Hjulet begyndte at spille");
        return brugerBetBeløbInt;
    }
}

static int returnEtTilfældigtTal()
{
    //ruller et tilfældigt tal fra 0 til 37 og retunerer derefter det tal.
    Random rand = new Random();
    int randomTal = rand.Next(0, 36);
    Console.WriteLine("Der blev rullet et tilfældigt tal. Tallet er: {0}", randomTal);
    return randomTal;
}

static int[] modtagBetType(string tagImodBetType)
{
    int[] rødeTal = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
    int[] sorteTal = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
    int[] tomArray = { };

    //array loop til 1-18 array
    int[] tal1Til18 = new int[18];
    int mindsteTal = 0;
    for (int i = 0; i < tal1Til18.Length; i++)
    {
        mindsteTal = mindsteTal + 1;
        tal1Til18[i] = mindsteTal;
    }

    //array loop til 19-36 array
    int[] tal19Til36 = new int[18];
    mindsteTal = 18;
    for (int i = 0; i < tal1Til18.Length; i++)
    {
        mindsteTal = mindsteTal + 1;
        tal19Til36[i] = mindsteTal;
    }

    //array loop til ulige tal.
    int[] uligeTal = new int[18];
    mindsteTal = -1;
    for (int i = 0; i < uligeTal.Length; i++)
    {
        mindsteTal = mindsteTal + 2;
        uligeTal[i] = mindsteTal;
    }

    //array loop til lige tal.
    int[] ligeTal = new int[18];
    mindsteTal = 0;
    for (int i = 0; i < ligeTal.Length; i++)
    {
        mindsteTal = mindsteTal + 2;
        ligeTal[i] = mindsteTal;
    }

    //definering af enkelttalsarray
    int[] enkeltTal = new int[1];

    if (tagImodBetType == "1")
    {
        return rødeTal;
    }
    else if (tagImodBetType == "2")
    {
        return sorteTal;
    }
    else if (tagImodBetType == "3")
    {
        return tal1Til18;
    }
    else if (tagImodBetType == "4")
    {
        return tal19Til36;
    }
    else if (tagImodBetType == "5")
    {
        return uligeTal;
    }
    else if (tagImodBetType == "6")
    {
        return ligeTal;
    }
    else if (tagImodBetType == "7") 
    {
        Console.Write("Hvilket enkelt tal skal der satses på? Skriv et helt tal mellem 1 og 36 her -> ");
        string mindsteTalstring = Console.ReadLine();
        int mindsteTalInt = Convert.ToInt32(mindsteTalstring);
        enkeltTal[0] = mindsteTalInt;
        return enkeltTal;
    }
    else
    {
        Console.WriteLine("Ukendt svar");
        return tomArray;
    }
}

//skal mere tilføjes under denne f.eks. ved tilfædlgittla så denne bliver til random tal i stedet eller burde det stadig virke?
static bool sammenlignTilfældigttalMedBrugerBet(int[] listeMedTal, int tilfældigtTal)
{
    //sammenligner "returnEtTilfældigtTal" med "modtagBetUndertype"
    for (int i = 0; i < listeMedTal.Length; i++)
    {
        if (listeMedTal[i] == tilfældigtTal)
        {
            return true;
        }
        else 
        {
            //tom med vilje for at illustrere kode vejen.
        }
    }
    return false;
}

static int beregnGevinst(bool gevinstEllerEj, string tagImodBetType, int variabelTilModtagBetBeløb) 
{
    if (gevinstEllerEj == false)
    {
        Console.WriteLine("Der er blevet tabt. Kontoen er opdateret");
        return 0 - variabelTilModtagBetBeløb;
    }
    else
    {
        Console.WriteLine("Der er gevinst! Kontoen er opdateret");
        if (tagImodBetType == "1" || tagImodBetType == "2" || tagImodBetType == "3" || tagImodBetType == "4" || tagImodBetType == "5" || tagImodBetType == "6")
        {
            return 2 * variabelTilModtagBetBeløb;
        }
        else if (tagImodBetType == "7")
        {
            return 35 * variabelTilModtagBetBeløb;
        }
        else
        {
            Console.WriteLine("Error");
            return 0;
        }
    }
}

static int opdaterSaldo(int saldo, int variabelTilGevinstUdregning)
{
    //bruger saldo til at minuses med "modtagBetBeløb" eller ganges med odsne vinningen. som f.eks. er *35 ved rigtigt gæt på et enkelt tal. Måske returner den også saldo. bare
    //den opdaterede version.

    Console.WriteLine("Den nye saldo er {0}", saldo + variabelTilGevinstUdregning);
    return saldo + variabelTilGevinstUdregning;
}

static bool spilIgen(int saldo)
{
    //looper alle de andre metoder igennem igen hvis svaret til spil igne er ja med en opdateret saldo. Hvis bruger beløb bliver 0 kan der ikke spilles igne medmindre
    //programmet genstartes. Ellers stopper programmet.
    Console.Write("Ønskes der at spilles igen? (J/N) -> ");
    string vilBrugerSpilleIgen = Console.ReadLine();
    if (vilBrugerSpilleIgen == "j" || vilBrugerSpilleIgen == "J" && saldo > 0)
    {
        Console.WriteLine("Der er blevet svaret ja. Programmet vil gentages.");
        Console.Clear();
        return true;
    }
    else if (vilBrugerSpilleIgen == "j" || vilBrugerSpilleIgen == "J" && saldo <= 0)
    {
        Console.WriteLine("Beklager der er ikke flere penge at spille for. Spillet stopper");
        return false;
    }
    else
    {
        Console.WriteLine("Der er blevet svaret nej. Programmet vil stoppe.");
        return false;
    }
}