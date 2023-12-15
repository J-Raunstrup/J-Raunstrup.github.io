// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//input

//udregning

//output


//hvad burde programmet bestå af?

//visMenu. viser brugerens muligheder for at analysere en given tekst. 1. lixtallet. 2. længden af teksten målt i antal ord. 3. en statestik over ordforkomster i tal + procent.
//derefter kan brugeren skrive det pågældende svar i tal. som derefter kan gemmes i en variabel og sættes som det funktionen skal retunere.

//modtagTekst. Tager imod tekst fra bruger og gemmes i en variabel. jeg ved ikke hvordan man får et program til at modtage filer. jeg tænker dog man bare kan lave kontrol v ind
//i programmet.

//lixtal udregner. kræver antal ord i teksten. kunne være en variabel. derudover en variabel der angiver punktummer. kommaer udråbstegn. kolon og ? i teksten som et fælles tal.
//og derudover en 3. variabel der er antal af lange ord. altså ord der er over 6 bogstaver lange. hver af disse 3 burde være variabler. flere af dem skal måske
//retuneres via metoder og derefter gemmes i variabler.

//fjernTegnTilTekst. fjerner tekstens punktummer kommaer, udråbstegn, spørgsmålstegn og kolon. den nye trimmede tekst kunne så gemmes i en variabel. måske en ide også at
//inkludere mellemrum. dog måske bedre at have ved beregntekstLængde metoden. Til sidst retunerer denne en string variabel.

//beregnTekstLængde. Tager imod en variabel skal måske bruge en split command der splitter hvert mellemrum op og så putter hvert ord i en array? der derefter tæller anttallet
//af gange i går op og skriver i ud til sidst. dermed ville man kunne få ord antallet tror jeg. Dog ikke sikker. Dette ville måske kræve en tekst fil?
//mere i tvilv om hvordan man giver den teksten.

//udregnStatestikOverOrdForkomster. udregner en statestik over antallet af forkomster hvert ord har. Den kræver noget tekst. måske gemt i endten en string variabel eller
//en array. Derefter skal den bruge tekstlængden af ord for at kunne dividere det enkelte ords forkomster med det hele antal af ord og derefter gange med 100. for at få det
//i procent. antallet af gange tror jeg kan skaffes ved brug af indexering i et for loop og gå en op hver gang der er et nyt ord og så bare skrive det sidste i variabel tal
//til sidst som så vil være antallet af gange programmet har kørt mener jeg.

//msåek skal udregnstatestikOverOrdForkomster og visStatestikOverOrdForkomster være en og ikke 2 funktioner. eller måske skal der være endnu en funktion der udregner
//procentdelen seperat

//visStatestikOverOrdForkomster


//lø'sning 1 og 2 klaret. 3. mangler.


//mangler at lave menu funktion og skrive tekst ind til sidste svar. så burde dette være færdigt.

//globale variabler.
//dette er hvis programmet skal aflæse en tekst fil ude fra. 1/2 start
using System;
using System.IO;
using System.Text;
//dette er hvis programmet skal aflæse en tekst fil ude fra. 1/2 slut

int iAntalOrd = 0;
int iAntalPunktommer = 0;
int iAntalLangeOrd = 0;



string sBrugerensTekst = modtagTekst();

//beregner tekstens længde i antal ord. svar mulighed 2/3 
string[] aBrugerensTekst = sBrugerensTekst.Split(" ");
iAntalOrd = aBrugerensTekst.Length;

iAntalPunktommer = findAntalPunktommer(aBrugerensTekst, iAntalPunktommer);
iAntalLangeOrd = findAntalLangeOrd(aBrugerensTekst, iAntalLangeOrd);

string[] aBrugerensTekstUdenTegn = fjernTegnTilTekst(aBrugerensTekst);
int iLixtalVudering = lixtalUdregner(iAntalOrd, iAntalPunktommer, iAntalLangeOrd);
//kan skrive antal ord via en console.writeline(iAntalOrd) her. så er løsning 2 klaret.

string[] aHvertIndivudeltOrdITekst = findHvertIndivudeltOrdITekst(aBrugerensTekstUdenTegn);

int[] aHvertOrdsAntalForkomster = udregnAntalAfHvertOrdForkomster(aBrugerensTekstUdenTegn, aHvertIndivudeltOrdITekst);

double[] aHvertOrdsAntalForkomsterIProcent = udregnAntalAfHvertOrdForkomsterIProcent(iAntalOrd, aHvertOrdsAntalForkomster);

//fjernet som test
//visStatestikOverOrdForkomster(aHvertOrdsAntalForkomster, aHvertOrdsAntalForkomsterIProcent, aHvertIndivudeltOrdITekst);

string sBrugerMenuSvar = visMenu();

visBrugerSvar(sBrugerMenuSvar, iLixtalVudering, iAntalOrd, aHvertOrdsAntalForkomster, aHvertOrdsAntalForkomsterIProcent, aHvertIndivudeltOrdITekst);

//viser brugermenu
static string visMenu() 
{
    Console.WriteLine("Menu");
    Console.WriteLine("jeg kan vise dig en af følgende 3 ting ud fra en tekst:");
    Console.WriteLine("1: Lixtallet");
    Console.WriteLine("2: Længden af teksten målt i antal af ord");
    Console.WriteLine("3: En statestik over ordforekomster i tal + procent");
    Console.Write("Tast venligst svar her (1/2/3) -> ");
    string sBrugerMenuSvar = Console.ReadLine();
    return sBrugerMenuSvar;
}

static void visBrugerSvar(string sBrugerMenuSvar, int iLixtalVudering, int iAntalOrd, int[] aHvertOrdsAntalForkomster, 
    double[] aHvertOrdsAntalForkomsterIProcent, string[] aHvertIndivudeltOrdITekst) 
{
    if (sBrugerMenuSvar == "1")
    {
        Console.WriteLine(iLixtalVudering);
    }
    else if (sBrugerMenuSvar == "2")
    {
        Console.WriteLine(iAntalOrd);
    }
    else if (sBrugerMenuSvar == "3")
    {
        visStatestikOverOrdForkomster(aHvertOrdsAntalForkomster, aHvertOrdsAntalForkomsterIProcent, aHvertIndivudeltOrdITekst);
    }
    else 
    {
        Console.WriteLine("Dette var ikke en svarmulighed");
    }
}



//modtager en tekst at analysere
static string modtagTekst() 
{
    //dette er hvis det er en predefineret skrevet tekst.
    /*
    string s = "For meget lang tid siden, gik en mand rundt på en mark og slog til småsten med en lang stok!";
    return s;
    */

    //dette er hvis programmet skal aflæse en tekst fil ude fra. 2/2 start
    string path = @"C:\Users\admin\Documents\kanyewestpowertest.txt";

    string content = File.ReadAllText(path, Encoding.UTF8);
    return content;
    //slut af aflæse tekst fil. 2/2 slut
}


static int findAntalPunktommer(string[] aBrugerensTekst, int iAntalPunktommer)
{
    for (int i = 0; i < aBrugerensTekst.Length; i++)
    {
        string s = aBrugerensTekst[i];
        if (s[s.Length - 1] == '.' || s[s.Length - 1] == '?' || s[s.Length - 1] == ',' || s[s.Length - 1] == ':' || s[s.Length - 1] == '!')
        {
            iAntalPunktommer = iAntalPunktommer + 1;
        }
        //ved godt det er overflødigt. ser bare pænere ud og nemmere at læse.
        else
        {
            iAntalPunktommer = iAntalPunktommer;
        }
    }
    return iAntalPunktommer;
}



static int findAntalLangeOrd(string[] aBrugerensTekst, int iAntalLangeOrd)
{
    for (int i = 0; i < aBrugerensTekst.Length; i++) 
    {
        string s = aBrugerensTekst[i];
        if (s.Length > 6)
        {
            iAntalLangeOrd = iAntalLangeOrd + 1;
        }
        //overflødig nedeunder. bare nemmere at læse.
        else 
        {
            iAntalLangeOrd = iAntalLangeOrd;
        }
    }
    return iAntalLangeOrd;
}



//udregner lixtal. 1 ud af 3 menu svar muligheder.
static int lixtalUdregner(int iAntalOrd, int iAntalPunktommer, int iAntalLangeOrd) 
{
    int iLixtalVærdi = (iAntalOrd / iAntalPunktommer) + ((iAntalLangeOrd * 100) / iAntalOrd);
    return iLixtalVærdi;
}



// fjerner tegn i en tekst der ikke tilhører ord så der kan skabes en array kun med ord bestående af bogstaver og ikke tegn.
//først loop. så if else. hvis tegn til sidst er . f.eks. så skal den tage fra 0 til variabelnavn.Length -1. hvis ikke så skal den bare tage fra 0 til variabel.Length gætter
//jeg på. derefter retuner tekst
static string[] fjernTegnTilTekst(string[] aBrugerensTekst) 
{
    string[] aCleanArrayMedOrd = new string[aBrugerensTekst.Length];
    for (int i = 0; i < aBrugerensTekst.Length; i++) 
    {
        string s = aBrugerensTekst[i];
        if (s[s.Length - 1] == '.' || s[s.Length - 1] == '?' || s[s.Length - 1] == ',' || s[s.Length - 1] == ':' || s[s.Length - 1] == '!')
        {
            string sKopiAfOrdMedFjernetTegn = s.Substring(0, s.Length - 1);
            aCleanArrayMedOrd[i] = sKopiAfOrdMedFjernetTegn;
        }
        else
        {
            string sKopiAfOrdUdenTegn = s.Substring(0, s.Length);
            aCleanArrayMedOrd[i] = sKopiAfOrdUdenTegn;
        }
    }
    return aCleanArrayMedOrd;
}



////skal mere tilføjes under denne f.eks. ved tilfædlgittla så denne bliver til random tal i stedet eller burde det stadig virke?
static bool eksistererOrdAllerede(string[] aBrugerensTekstUdenTegn, string sOrdTilDuplikeringsTjek)
{
    //sammenligner "returnEtTilfældigtTal" med "modtagBetUndertype"
    for (int i = 0; i < aBrugerensTekstUdenTegn.Length; i++)
    {
        if (aBrugerensTekstUdenTegn[i] == sOrdTilDuplikeringsTjek)
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

//tjeker hele originale array for genbrugte ord. Derefter hvis ordenen ikke er brugt i den nye array vil pladsen blive brugt til dette, Derefter i bliver en gang større
//hvorefter denne proces gentages.
//finder hvert indivudelt ord i en tekst og putter dem i en array med hver sin plads så der ikke er duplikeringer. dette skulle bruges til at vise statestikken ved
//3. svar mulighed
static string[] findHvertIndivudeltOrdITekst(string[] aBrugerensTekstUdenTegn) 
{
    //denne kommer til at have tomme pladser.
    string[] aHvertIndividueltOrdITekstMedTommePladser = new string[aBrugerensTekstUdenTegn.Length];
    int j = 0;
    for (int i = 0; i < aBrugerensTekstUdenTegn.Length; i++)
    {
        if (eksistererOrdAllerede(aHvertIndividueltOrdITekstMedTommePladser, aBrugerensTekstUdenTegn[i]) != true)
        {
            aHvertIndividueltOrdITekstMedTommePladser[j] = aBrugerensTekstUdenTegn[i];
            j++;
        }
        else 
        {
            //overflødig.   
        }
    }

    string[] aModtagNyIndivduelleOrd = new string[j];
    for (int i = 0; i < aModtagNyIndivduelleOrd.Length; i++) 
    {
        aModtagNyIndivduelleOrd[i] = aHvertIndividueltOrdITekstMedTommePladser[i];
    }

    return aModtagNyIndivduelleOrd;
}



static int[] udregnAntalAfHvertOrdForkomster(string[] aBrugerensTekstUdenTegn, string[] aHvertIndivudeltOrdITekst) 
{
    int[] aAntalGangeHvertOrdForkommer = new int[aHvertIndivudeltOrdITekst.Length];
    for(int u= 0; u < aAntalGangeHvertOrdForkommer.Length; u++)
    {
        aAntalGangeHvertOrdForkommer[u] = 0;
    }
    for (int i = 0; i < aHvertIndivudeltOrdITekst.Length; i++) 
    {
        

        for (int t = 0; t < aBrugerensTekstUdenTegn.Length; t++)
        {
            if (aHvertIndivudeltOrdITekst[i] == aBrugerensTekstUdenTegn[t])
            {
                aAntalGangeHvertOrdForkommer[i]++;
            }
            else 
            {
             //overflødig   
            }
        }
    }
    return aAntalGangeHvertOrdForkommer;
}



static double[] udregnAntalAfHvertOrdForkomsterIProcent(int iAntalOrd, int[] aHvertOrdsAntalForkomster) 
{
    double[] aProcentAndelForkomstAfHeleTekst = new double[aHvertOrdsAntalForkomster.Length];
    for (int i = 0; i < aHvertOrdsAntalForkomster.Length; i++) 
    {
        aProcentAndelForkomstAfHeleTekst[i] = (Convert.ToDouble(aHvertOrdsAntalForkomster[i]) / Convert.ToDouble(iAntalOrd)) * 100;
    }
    return aProcentAndelForkomstAfHeleTekst;
}



// Svar mulighed 3/3. viser en statestik over hvert ords forkomst både i antal og procent og tager aHvertOrdsAntalForkomster, aHvertOrdsAntalForkomsterIProcent,
// aHvertIndivudeltOrdITekst. Som parametre blandt andet for at finde svaret på den 3. svar mulighed og vise en statestik over alle forskellige ord. hvert med antal
// og procentandel af den hele tekst de tages fra.

static void visStatestikOverOrdForkomster(int[] aHvertOrdsAntalForkomster, double[] aHvertOrdsAntalForkomsterIProcent, string[] aHvertIndivudeltOrdITekst)
{
    string testtesto;
    for (int i = 0; i < aHvertIndivudeltOrdITekst.Length; i++) 
    {
        testtesto = aHvertIndivudeltOrdITekst[i] + " | " + aHvertOrdsAntalForkomster[i] + " | " + aHvertOrdsAntalForkomsterIProcent[i] + "%";
        Console.WriteLine(testtesto);
    }
}