// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//opgave F.1
//obligatorisk opgave
/*
string sLangSampleTekstFraOpgave = "Uglen er en rovfugl. Ikke alle rovfugle er ugler. En ugle spiser mus og gylper uglegylp. Alle ugler er gode ugler. " +
    "De fleste har været små ugleunger med en uglemor og en uglefar. Er ugler uglede i håret? Hvor mange ugler kan bo i en uglerede?";
string sLangSampleTekstFraOpgaveGjortTilSmåBogstaver = sLangSampleTekstFraOpgave.ToLower();


string[] aLangSampleTekstFraOpgaveSmåBogstaver = sLangSampleTekstFraOpgaveGjortTilSmåBogstaver.Split(' ');


for (int i = 0; i < aLangSampleTekstFraOpgaveSmåBogstaver.Length; i++) 
{
    int target = aLangSampleTekstFraOpgaveSmåBogstaver[i].IndexOf("ugle");
    if (target == 0) 
    {
        if (aLangSampleTekstFraOpgaveSmåBogstaver[i][aLangSampleTekstFraOpgaveSmåBogstaver[i].Length-1] == '.' ||
            aLangSampleTekstFraOpgaveSmåBogstaver[i][aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1] == '?' || 
            aLangSampleTekstFraOpgaveSmåBogstaver[i][aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1] == '!') 
        {
            aLangSampleTekstFraOpgaveSmåBogstaver[i] = aLangSampleTekstFraOpgaveSmåBogstaver[i].Substring(0, aLangSampleTekstFraOpgaveSmåBogstaver[i].Length-1);
        }
        Console.WriteLine(aLangSampleTekstFraOpgaveSmåBogstaver[i]);
    }
}
Console.WriteLine();
*/

//opgave F.1
//obligatorisk opgave
//ekstra ogpave
/*
string sLangSampleTekstFraOpgave = "Uglen er en rovfugl. Ikke alle rovfugle er ugler. En ugle spiser mus og gylper uglegylp. Alle ugler er gode ugler. " +
    "De fleste har været små ugleunger med en uglemor og en uglefar. Er ugler uglede i håret? Hvor mange ugler kan bo i en uglerede?";
string sLangSampleTekstFraOpgaveGjortTilSmåBogstaver = sLangSampleTekstFraOpgave.ToLower();



string[] aLangSampleTekstFraOpgaveSmåBogstaver = sLangSampleTekstFraOpgaveGjortTilSmåBogstaver.Split(' ');
string[] aModtagerArrayTilUgleOrd = new string[aLangSampleTekstFraOpgaveSmåBogstaver.Length];
int idx = 0;
for (int i = 0; i < aModtagerArrayTilUgleOrd.Length; i++)
{
    aModtagerArrayTilUgleOrd[i] = "";

}

for (int i = 0; i < aLangSampleTekstFraOpgaveSmåBogstaver.Length; i++)
{
    int target = aLangSampleTekstFraOpgaveSmåBogstaver[i].IndexOf("ugle");
    if (target == 0)
    {
        if (aLangSampleTekstFraOpgaveSmåBogstaver[i][aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1] == '.' ||
            aLangSampleTekstFraOpgaveSmåBogstaver[i][aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1] == '?' ||
            aLangSampleTekstFraOpgaveSmåBogstaver[i][aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1] == '!')
        {
            aLangSampleTekstFraOpgaveSmåBogstaver[i] = aLangSampleTekstFraOpgaveSmåBogstaver[i].Substring(0, aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1);
        }
        aModtagerArrayTilUgleOrd[idx] = aLangSampleTekstFraOpgaveSmåBogstaver[i];
        idx++;
    }
}

for (int i = 0; i < aModtagerArrayTilUgleOrd.Length; i++)
{
    Console.WriteLine(aModtagerArrayTilUgleOrd[i]);
}
Console.WriteLine();
Console.WriteLine();
*/

//opgave F.1
//fik meget hjælp til alle 3. specielt del 2 og 3.
/*
//master
string sLangSampleTekstFraOpgave = "Uglen er en rovfugl. Ikke alle rovfugle er ugler. En ugle spiser mus og gylper uglegylp. Alle ugler er gode ugler. " +
    "De fleste har været små ugleunger med en uglemor og en uglefar. Er ugler uglede i håret? Hvor mange ugler kan bo i en uglerede?";
string sLangSampleTekstFraOpgaveGjortTilSmåBogstaver = sLangSampleTekstFraOpgave.ToLower();



string[] aLangSampleTekstFraOpgaveSmåBogstaver = sLangSampleTekstFraOpgaveGjortTilSmåBogstaver.Split(' ');
string[] aModtagerArrayTilUgleOrd = new string[aLangSampleTekstFraOpgaveSmåBogstaver.Length];
int idx = 0;
for (int i = 0; i < aModtagerArrayTilUgleOrd.Length; i++)
{
    aModtagerArrayTilUgleOrd[i] = "";

}

for (int i = 0; i < aLangSampleTekstFraOpgaveSmåBogstaver.Length; i++)
{
    int target = aLangSampleTekstFraOpgaveSmåBogstaver[i].IndexOf("ugle");
    
    if (target == 0)
    {
        if (aLangSampleTekstFraOpgaveSmåBogstaver[i][aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1] == '.' ||
            aLangSampleTekstFraOpgaveSmåBogstaver[i][aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1] == '?' ||
            aLangSampleTekstFraOpgaveSmåBogstaver[i][aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1] == '!')
        {
            aLangSampleTekstFraOpgaveSmåBogstaver[i] = aLangSampleTekstFraOpgaveSmåBogstaver[i].Substring(0, aLangSampleTekstFraOpgaveSmåBogstaver[i].Length - 1);
        }
        if (stringAlreadyInarray(aModtagerArrayTilUgleOrd, aLangSampleTekstFraOpgaveSmåBogstaver[i]) == false) 
        {
            aModtagerArrayTilUgleOrd[idx] = aLangSampleTekstFraOpgaveSmåBogstaver[i];
            idx++;
        }
    }
}

int count = 0;

for (int i = 0; i < aModtagerArrayTilUgleOrd.Length; i++) 
{
    if (aModtagerArrayTilUgleOrd[i] != "") 
    {
        count++;
    }
}

string[] aSidsteArray = new string[count];

for (int i = 0; i < aSidsteArray.Length; i++) 
{
    aSidsteArray[i] = aModtagerArrayTilUgleOrd[i];
    Console.WriteLine(aSidsteArray[i]);
}


Console.WriteLine();
Console.WriteLine();


static bool stringAlreadyInarray(string[] a, string s)
{
    //ved nedestående linje laves en bool variabel kaldet returnValue. den sættes = false.
    bool returnValue = false;
    //her laves et loop som fortsætter med at køre indtil arrayens længde er nået til slut.
    for (int i = 0; i < a.Length; i++)
    {
        //her skrives at hvis index pladsen i arrayet er = tallet n(parameter til functionen). Så vil den sætte den tidligere bool værdi returnValue = true altså sige at det genrerede tal allerede
        //eksisterer.
        if (a[i] == s)
        {
            returnValue = true;
        }
    }
    //her angives det at functionen retunerer hvorvidt tallet findes eller ej.
    return returnValue;

}
*/

//opgave F.2
// menu og ønsket elev antal.

Console.WriteLine("Dette er en karakter liste viser og karakter gennemsnit beregner. Den kræver antal elever og karaktererne hver elev har fået på faget programmering");
Console.Write("SKriv antal elever her i helt tal -> ");
string sAntalElever = Console.ReadLine();
int iAntalElever = Convert.ToInt32(sAntalElever);

string[] aElevListe = new string[iAntalElever];
int[] aKarakterListe = new int[iAntalElever];

int iNuværendeElev = 1;

//input
for (int i = 0; i < iAntalElever; i++) 
{
    Console.WriteLine("");
    Console.WriteLine("Nuværende elev nr: {0} ud af {1}", iNuværendeElev, iAntalElever);

    Console.WriteLine("Skriv elev information nederunder dette (1/3)");

    Console.Write("Skriv fulde elev navn her (2/3) -> ");
    string sFuldeElevNavn = Console.ReadLine();
    aElevListe[i] = sFuldeElevNavn;

    Console.Write("Skriv {0}'s karakter i programmering her (3/3) -> ", sFuldeElevNavn);
    string sElevKarakter = Console.ReadLine();
    
    int iElevKarakter = Convert.ToInt32(sElevKarakter);
    aKarakterListe[i] = iElevKarakter;

    iNuværendeElev++;
}

Console.Clear();
string sBrugerØnskedeOutput = "";

menuMedBrugerValg(sBrugerØnskedeOutput, aElevListe, aKarakterListe, iAntalElever);



//metoder
static void listeMedKaraktererOgNavne(string[] aElevListe, int[] aKarakterListe)
{
    for (int i = 0; i < aElevListe.Length; i++)
    {
        Console.WriteLine("Navn: " + aElevListe[i]);
        Console.WriteLine("Karakter: " + aKarakterListe[i]);
        Console.WriteLine();
    }
}

static void karakterGennemsnit(int[] aKarakterListe, int iAntalElever) 
{
    double dKaraktergennemsnit = 0;
    double dSamledeVærdi = 0;

    for (int i = 0; i < aKarakterListe.Length; i++)
    {
        dSamledeVærdi = dSamledeVærdi + aKarakterListe[i];
    }

    dKaraktergennemsnit = (dSamledeVærdi / iAntalElever);

    Console.WriteLine("Karaktergennemsnit for alle {0} elever: {1}", iAntalElever, dKaraktergennemsnit);
    Console.WriteLine();
}

static void menuMedBrugerValg(string sBrugerØnskedeOutput, string[] aElevListe, int[] aKarakterListe, int iAntalElever) 
{
    do
    {
        Console.WriteLine();
        Console.WriteLine("Menu");
        Console.WriteLine("Tak for informationerne. Hvad ønsker man at se?");
        Console.WriteLine("1: Karakterliste");
        Console.WriteLine("2: Gennemsnits udregning");
        Console.WriteLine("3: Afslut");
        Console.Write("Skriv svar her med et af tallene til højre. (1/2/3) -> ");
        sBrugerØnskedeOutput = Console.ReadLine();
        Console.WriteLine();
        if (sBrugerØnskedeOutput == "1")
        {
            //output
            //karakterognavneliste output
            Console.WriteLine("Der blev valgt 1. Altså Karakterliste. Programmet vil skrive eleverne ud på skærmen med deres karakterer.");
            Console.WriteLine();
            listeMedKaraktererOgNavne(aElevListe, aKarakterListe);
            Console.Write("Tryk på en tast for at fortsætte");
            Console.ReadKey();
            Console.Clear();
        }
        else if (sBrugerØnskedeOutput == "2")
        {
            //udregning
            Console.WriteLine("Der blev valgt 2. Altså Gennemsnits udregning. Programmet vil udregne gennemsnits karakteren blandt de indtastede elever.");
            karakterGennemsnit(aKarakterListe, iAntalElever);
            Console.Write("Tryk på en tast for at fortsætte");
            Console.ReadKey();
            Console.Clear();
        }
        else if (sBrugerØnskedeOutput == "3")
        {
            Console.WriteLine("Der blev valgt 3. Altså afslut. Programmet vil stoppe.");
        }
        else
        {
            Console.WriteLine("Ukendt svar mulighed");
        }
    }
    while (sBrugerØnskedeOutput != "3");
}


//opgaver:
//1 done.
//2 done.
//3 done tror jeg.
//4 done. godkendt af Jakob
//5 done. godkendt af Jakob