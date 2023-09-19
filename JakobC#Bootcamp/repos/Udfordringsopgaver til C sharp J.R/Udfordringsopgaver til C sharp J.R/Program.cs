// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Opgave U.1 numerologi
/*
Console.WriteLine("Numerologi program");
Console.WriteLine("Jeg skal bruge nogle informationer for at kunne analysere");

Console.Write("Skriv din fødselsdato her i hele tal med følgende format med mellemrum (D D M M Å Å Å Å) -> ");
string sBrugerFødselsdato = Console.ReadLine();

string[] aBrugerFødselsdato = sBrugerFødselsdato.Split(" ");

//output checker af array
for (int i = 0; i < aBrugerFødselsdato.Length; i++) 
{
    Console.WriteLine(aBrugerFødselsdato[i]);
}

static void tegnTilTalConverter() 
{
    
}
*/

//delopgaver
//Livslektie done

//her oplyses brugeren om hvilke program dette er
Console.WriteLine("Numerologi program");
Console.WriteLine("Livslektie program");
//her fortælles brugeren hvad programmet vil forsøge at udregne og hvilke informationer det skal bruge til dette.
Console.WriteLine("Jeg vil forsøge at finde din livs lektie ud fra dit fødselsnummer.");
//her oplyses brugeren om ønskede input. i dette tilfælde fødslesdato.
Console.Write("Skriv Venligst fødselsdato her (DDMMÅÅÅÅ)-> ");
//her tages imod brugerens indtastning og gemmes i en string variabel kaldet sBrugerFødselsTal
string sBrugerFødselsTal = Console.ReadLine();
//her skrives brugerens fødselsdato ud på skærmen så man kan se datoen er tastet rigtigt.
Console.WriteLine(sBrugerFødselsTal);   


//her laves en int array kaldet aBrugerFødselsTal. Den sættes = en metode kaldet tekstTilTalKonverter med en parametre af sBrugerFødselstal.? er det rigtigt?
int[] aBrugerFødselsTal = tekstTilTalKonverter(sBrugerFødselsTal);

//her kaldes en metode kaldet livsLektieUdregner som tager en parametre af aBrugerFødselsTal fra tidligere.
int iSamledeVærdiTilLivsLektie = talMeningsUdregner(aBrugerFødselsTal);


string sTextTilCheckTalletsEnergi = checkTalletsEnergi(iSamledeVærdiTilLivsLektie);

Console.WriteLine();
skrivTalEnergid(sTextTilCheckTalletsEnergi);

//Samfundsopgaven
Console.WriteLine();
Console.WriteLine("Numerologi program");
Console.WriteLine("Samfundsopgave program");
Console.WriteLine("Jeg vil forsøge at finde din samfundspgave ud fra de sidste 4 cifre i dit cpr nummer.");
Console.Write("Skriv Venligst de sidste 4 tal her (TTTT)-> ");
string sBrugerSidsteFireCPRTal = Console.ReadLine();
int[] aBrugerSidsteFireCPRTal = tekstTilTalKonverter(sBrugerSidsteFireCPRTal);

int iSamledeVærdiTilSamfundsOpgave = talMeningsUdregner(aBrugerSidsteFireCPRTal);

sTextTilCheckTalletsEnergi = checkTalletsEnergi(iSamledeVærdiTilSamfundsOpgave);
Console.WriteLine();
skrivTalEnergid(sTextTilCheckTalletsEnergi);

//Motivation
Console.WriteLine();
Console.WriteLine("Numerologi program");
Console.WriteLine("Motivations program");
Console.WriteLine("Jeg vil forsøge at finde din motivation ud fra dit navn");
Console.Write("Skriv Venligst navn her -> ");
string sBrugerNavn = Console.ReadLine();
sBrugerNavn = sBrugerNavn.ToLower();
sBrugerNavn = sBrugerNavn.Replace("aa", "#");

int sum = 0;

    findTalVærdiTilHvertCharINavn(sBrugerNavn);
    int[] aTalFraNavn = converterNavnTilTal(sBrugerNavn);
    sTextTilCheckTalletsEnergi = checkTalletsEnergi(talMeningsUdregner(converterNavnBogstaverVokalerTilTal(sBrugerNavn)));
    skrivTalEnergid(sTextTilCheckTalletsEnergi);

//indtryk
Console.WriteLine();
Console.WriteLine("Numerologi program");
Console.WriteLine("Indtryk");
    sTextTilCheckTalletsEnergi = checkTalletsEnergi(talMeningsUdregner(converterNavnBogstaverKonsonanterTilTal(sBrugerNavn)));
    skrivTalEnergid(sTextTilCheckTalletsEnergi);

//udtrykket
Console.WriteLine();
Console.WriteLine("Numerologi program");
Console.WriteLine("utrykket");


//tror fejl er HER
sTextTilCheckTalletsEnergi = checkTalletsEnergi((talMeningsUdregner(converterNavnTilTal(sBrugerNavn))));
Console.WriteLine("Samlede værdi:");
skrivTalEnergid(sTextTilCheckTalletsEnergi);


//metoder
//her skabes metoden tekstTilTalKonverter. Som tager parametren sBrugerFødselstal. altså brugerens fødselstal fra starten af opgaven.
static int[] tekstTilTalKonverter(string sBrugerFødselsTal) 
{
    //her skabes en ny int kaldet aBrugerFødselsTal og får det samme antal pladser skabt som længden på sBrugerFødselsTal variablen.
    int[] aBrugerFødselsTal = new int[sBrugerFødselsTal.Length];
    //her skabes et for loop der vil køre så længe i er mindre end sBrugerFødselsTal længden. Derudover vil i blive 1 gang størrere hver gang dette loop har kørt.
    for (int i = 0; i < sBrugerFødselsTal.Length; i++)
    {
        //her sættes plads i altså hver plads i arrayet grundet dette vil køre indtil i er ligeså højt som længden på sBrugerFødselsTal's længde. Her sættes hver plads i
        //aBrugerFødselsTal's arrayen = sBrugerFødselsTal[i] altså hver plads i aBrugerFødselsTal sættes = hver tegn i sBrugerFødselsTal. Inden værdierne fra sBrugerFødselstal
        //kommer over i arrayet. Så skal de først konverteres da aBrugerFødselsTal er en int variabel. Derfor konverteres sBrugerFødselstal[i] tegnet som er en char.
        //Dette bliver converteret til en string med convert.ToString. derefter konverteres denne string videre til til en int med Conver.ToInt32. Så dette kan bruges til
        //udregninger.
        aBrugerFødselsTal[i] = Convert.ToInt32(Convert.ToString(sBrugerFødselsTal[i]));
    }
    //her laves endnu et loop der vil køre så længe i er mindre end længden på aBrugerFødselsTal's længde og hvor i bliver 1 større hver gang.
    for (int i = 0; i < aBrugerFødselsTal.Length; i++) 
    {
        //her vil der skrives hver plads en af gangen ud til konsollen grundet det er i et loop med indexet i. Altså vil alle pladser skrives oå skærmen indtil slutningen af
        //arrrayet er nået.
        //Console.WriteLine(aBrugerFødselsTal[i]);
    }
    //til sidst i denne metode vil programmet retunere aBrugerFødselsTal tilbage til programmet. Det vil i praksis betyde at aBrugerFødselstal. kan bruges igen i programmet
    //senere. Hvorimod hvis der ikke stod return ville værdien ikke blive tilgengelig i programmets globale scope. Dermed er det brugbart de tal kan bruges senere
    //da de skal bruges til udregninger senere.
    return aBrugerFødselsTal;
}



//her laves en metode kaldet livsLektieUdregner. Den gives en parametre af a som er en array. der skal består af integer værdier
static int talMeningsUdregner (int[] a) 
{
    //her sættes arrayen fra forrige metode = a. Det vil sige metoden ved at den skal bruge aBrugerFødselsTal og ikke a. da a bare er en parametre der ikke nødvendigvis
    //indeohlder noget endnu. Derfor gives den en værdi magen til aBrugerFødselsTal.?
    int[] aBrugerFødselsTal = a;
    //her laves en int variabel kaldet samledeVærdiTilLivsLektie. Den sættes = 0. Dette er for at den kan bruges i denne metodes scope. Iden der skal sættes værdier til den.
    int iSamledeVærdiTilLivsLektie = 0;
    //her laves et do while loop
    do
    {
        //her sættes samledeVærdiTilLivsLektie = 0. sådan så hver gang loopet kører at den ikke vil huske samledeVærdiTilLivsLektie og dermed lave fejl kalkulationer.
        iSamledeVærdiTilLivsLektie = 0;
        //her laves et for loop hvor at så længe i er mindre end aBrugerFødselsTal arrayen's længde. Så vil det køre.
        for (int i = 0; i < aBrugerFødselsTal.Length; i++)
        {
            //her vil hver gang loopet køre. Vil samledeVærdiTilLivsLektie sættes = sig selv + en pågældende plads fra aBrugerFødselsTal. Dermed vil dette blive ved med
            //at køre indtil alle pladser er nået?
            iSamledeVærdiTilLivsLektie = iSamledeVærdiTilLivsLektie + aBrugerFødselsTal[i];
        }
        //her skabes en string variabel kaldet sTest og sættes = samledeVærdiTilLivsLektie som er konverteret til en string. Hvorfor?
        string sTest = Convert.ToString(iSamledeVærdiTilLivsLektie);
        //her sættes aBrugerFødselsTal = tekstTilTalKonverter med parameter sTest. Hvorfor?
        aBrugerFødselsTal = tekstTilTalKonverter(sTest);
        //her beskrives det hvor længe do while loopet skal køre. Altså at loopet skal køre en gang og efter det kun skal køre indtil et af følgende sker:
        //endten at samledeVærdiTilLivsLektie er større eller = 10. eller samledeVærdiTilLivsLektie = 11 eller samledeVærdiTilLivsLektie == 22 eller
        //samledeVærdiTilLivsLektie == 33
    } while (iSamledeVærdiTilLivsLektie > 9 && iSamledeVærdiTilLivsLektie != 11 && iSamledeVærdiTilLivsLektie != 22 && iSamledeVærdiTilLivsLektie != 33);
    //her skrives outputtet af dette til brugeren. Som senere kan bruges til f.eks. et if else statement til at skrive forskkelige udfald.
    //Console.WriteLine("Samlede værdi: {0}", iSamledeVærdiTilLivsLektie);
    return iSamledeVærdiTilLivsLektie;
}
//mangler at tilføje if else statements efter hvilke tal det bliver.



static string checkTalletsEnergi(int iTalVærdi)
{
    if (iTalVærdi == 0)
    {
        string sTitel = "0 – Spirituel";
        string sBrødtekst = "Guds punkt og absolut væren.Denne energi giver dig mulighed for at være guddommelig bevidst med en særlig kosmisk ansvarlighed. " +
            "Kodeord=Kosmisk æg,grænseløs,alt eller intet,tro,renhed,uendelige muligheder,u-manifesteret,guds ånde,kilde,rum." +
            "(Danmark har motivation 0 altså gudommelig motivation.)Vi har jo også en Dronning der er troende:-)";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 1)
    {
        string sTitel = "1 – Individet";
        string sBrødtekst = "Vibrationen for skabelse,pioner, mod, uafhængighed, viljestyrke og troen på sig selv og egne ideer,solen. Der er ved denne vibration fare " +
            "for egoisme og mangel på interesse for andre.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 2)
    {
        string sTitel = "2 – Partneren";
        string sBrødtekst = "Denne vibration kræver fællesskab og er fuld af kærlighed, godhed og ønsker om at arbejde godt sammen med andre," +
            "stærk indfølingsevne/genert/kunstner i baggrunden,. Fare for svaghed og holdningsløshed.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 3)
    {
        string sTitel = "3 – Kunstneren";
        string sBrødtekst = "Tallet viser behov for kommunikation og kan lade sin energi komme til udtryk i skrift, tale, underholdning eller kunst,medie,tro/håb/kærlighed. " +
            "Fare for overdrevne talegaver og manglende koncentration.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 4)
    {
        string sTitel = "4 – Arbejdshest";
        string sBrødtekst = "Kærlighed på højt plan/platform=fundament, systemer/orden.Intet af værdi undgås, alt opnås og der er gode muligheder for at få alle detaljer med" +
            " ved tilstrækkelig selvdisciplin og koncentration. Fare for at blive kold og alvorlig.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 5)
    {
        string sTitel = "5 – Sigøjneren";
        string sBrødtekst = "Eksperimenterer med tilværelsen til yderste konsekvens og kan ikke underlægge sig rutinemæssige opgaver,sanselig,fleksibel, eventyrer,læser det " +
            "nonverbale sprog, symbollæser. Fare for ekstremer af alle slags, når det gælder laster/lyster.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 6)
    {
        string sTitel = "6 – Moderen";
        string sBrødtekst = "Den store mor.Påtager sig alverdens “byrder” og “pylrer” om alle og enhver. Kurerer fejl og uretfærdigheder, harmoniskaber " +
            ",elsker skønhed/kunst. Fare for påtrængenhed og at blande sig for meget i andres sager (Det Danske udtryk/indtryk i verden).";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 7)
    {
        string sTitel = "7 – Den lærde";
        string sBrødtekst = "Sindets tal for analyse af alle kendsgerninger. En evig søgen efter “sandheden”visdom,klart seende.Er en “særling” Behøver ro til meditation. " +
            "Fare for eneboer-tilværelse og overbekymring.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 8)
    {
        string sTitel = "8 – Forretningsmanden";
        string sBrødtekst = "Energien for handel og forretningsfolk. Leder andre mennesker og styrer projekter.Her handler det om at sammenkoble åndelighed med" +
            " materialistiske livs syn, undgå begærlighed da du er til for alle, som en transformator og den store boss, mennesker som møder dig må" +
            " forvandle sig, det er den proces du sætter igang, indtil nu måske ubevidst så take care. Fare for at blive enevældig og materialistisk.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 9)
    {
        string sTitel = "9 – Menneskevennen";
        string sBrødtekst = "Kan komme i snak med alle mennesker. Besidder alle andre tals kvaliteter og kan være kunstnerisk, uafhængig og effektiv,unik ,." +
            " Du har evnen til at være multikunstner.Du brænder for at passe på jorden,dyrene ,og menneskene.Dette er en person der har været her i gennem" +
            " mange liv/stærk ånd/sjæl/ønsker det perfekte liv. Faren for manglende personlig holdning.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 11)
    {
        string sTitel = "11 – Magikeren";
        string sBrødtekst = "Kilden til inspiration. Begavet med særlige evner, som kan lede andre. Original og idealistisk. Vær en god vejleder ved at lede" +
            " dig selv rigtigt,du er dobbelt pioner og henter viden fra fremtiden når du har mod til at stole på dig selv.Så vis vejen ved at gå den selv" +
            " eller sig tingene/ideen 1 gang så bliver det lagt ud tille kollektivt arbejde og ansvar -mod mod-mod,er dit stærkeste arbejde fordi du ofte" +
            " står alene til sidst på grund af din indsigt.brug kraften tag mig eller lad være!!! dine frø er vigtige og du kommer til at sætte mange, " +
            "lønnen kommer måske et andet sted fra da du ikke har tid til at vande alle dine frø og høste dem for så går dine energier til spilde, " +
            "universet er med dig!!!Undgå  fanatisme og magtmisbrug i så fald kommer du til at dyrke sort magi.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 22)
    {
        string sTitel = "22 – Bygmesteren";
        string sBrødtekst = "En stor kraft, som må behandles med varsomhed. Den visionære der gør drømme til virkelighed. Mester-analytiker med særlige opgaver. " +
            "Kærlighed på højt plan ,stærk beskyttelse. Fare for tvivl på egne evner og for at vælge mørkets vej.";
        return sTitel + "\n" + sBrødtekst;
    }
    else if (iTalVærdi == 33)
    {
        string sTitel = "33 – Kommunikation";
        string sBrødtekst = "Kommunikation på højt plan.Du er et medie med dobbelt styrke.Tro,håb,kærlighed er det vigtigste i arbejdet omkring dette tal. " +
            "Skrift-tale-medier-kunstner ,samt åndelig medie.Se også 3.For dig er det endnu mere vigtigt at bevare troen på dig selv at vide at alt sker " +
            "i den rigtige rækkefølge og i den rigtige orden samt at kærligheden er der altid ikke mindst inde i dig selv til dig selv. " +
            "Så tænk på energien omkring en magnet så ved du når du handler i kærlighedens navn. Med dobbelt tal har vil altid stor magt så brug den i kærlighedens navn.";
        return sTitel + "\n" + sBrødtekst;
    }
    else 
    {
        string sDefaultSvar = "Fejl. " + iTalVærdi + " er en ukendt tal værdi";
        return sDefaultSvar;
    }
}

static void skrivTalEnergid(string test) 
{
    Console.WriteLine(test);
}

static int findTalVærdiTilHvertCharINavn(string testString) 
{
    string sBogstavsAlphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z æ ø å #";
    string[] aBogstavsAlphabet = sBogstavsAlphabet.Split(" ");
    int[] aBogstavsAlphabetTalVærdier = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 0, 19, 20, 21, 22, 23, 24, 25, 26, 27 };
    for (int i = 0; i < aBogstavsAlphabet.Length; i++) 
    {
        if (aBogstavsAlphabet[i] == testString)
        {
            return aBogstavsAlphabetTalVærdier[i];
        }
        else 
        {
         
        }
    }
    return -1;
}

static int[] converterNavnTilTal(string testString) 
{
    int iTalFraNavn = 0;
    for (int i = 0; i < testString.Length; i++) 
    {
        iTalFraNavn = iTalFraNavn + findTalVærdiTilHvertCharINavn(Convert.ToString(testString[i]));
    }
    string sTalFraNavn = Convert.ToString(iTalFraNavn);
    int[] aTalFraNavn = new int [sTalFraNavn.Length];
    for (int i = 0; i < sTalFraNavn.Length; i++) 
    {
        aTalFraNavn[i] = Convert.ToInt32(Convert.ToString(sTalFraNavn[i]));
    }
    return aTalFraNavn;
}

static int[] converterNavnBogstaverVokalerTilTal(string testString)
{
    int iTalFraNavn = 0;
    for (int i = 0; i < testString.Length; i++)
    {
        if (erDetteEnVokal(testString[i]) == true)
        {
            iTalFraNavn = iTalFraNavn + findTalVærdiTilHvertCharINavn(Convert.ToString(testString[i]));

        }
    }
    string sTalFraNavn = Convert.ToString(iTalFraNavn);
    int[] aTalFraNavn = new int[sTalFraNavn.Length];
    for (int i = 0; i < sTalFraNavn.Length; i++)
    {
        aTalFraNavn[i] = Convert.ToInt32(Convert.ToString(sTalFraNavn[i]));

    }
    return aTalFraNavn;
}

static bool erDetteEnVokal(char cTest) 
{
    if (cTest == 'a' || cTest == 'e' || cTest == 'i' || cTest == 'o' || cTest == 'u' || cTest == 'y' || cTest == 'æ' || cTest == 'ø' || cTest == 'å' || cTest == '#') 
    {
        return true;
    }
    return false;
}

static int[] converterNavnBogstaverKonsonanterTilTal(string testString)
{
    int iTalFraNavn = 0;
    for (int i = 0; i < testString.Length; i++)
    {
        if (erDetteEnVokal(testString[i]) == false)
        {
            iTalFraNavn = iTalFraNavn + findTalVærdiTilHvertCharINavn(Convert.ToString(testString[i]));

        }
    }
    string sTalFraNavn = Convert.ToString(iTalFraNavn);
    int[] aTalFraNavn = new int[sTalFraNavn.Length];
    for (int i = 0; i < sTalFraNavn.Length; i++)
    {
         aTalFraNavn[i] = Convert.ToInt32(Convert.ToString(sTalFraNavn[i]));
        
    }
    return aTalFraNavn;
}

