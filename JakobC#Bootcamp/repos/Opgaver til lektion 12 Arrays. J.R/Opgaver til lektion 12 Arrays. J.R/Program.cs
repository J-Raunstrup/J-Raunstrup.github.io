// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//opgave 12.1 gjort til kommentar for at løse næste opgave.
/*
Console.WriteLine("Tal: ");
int[] iTilfældigeTal = new int[10];
int iMindsteTalStørrelse = 48;
for (int i = 0; i < iTilfældigeTal.Length; i++, iMindsteTalStørrelse = iMindsteTalStørrelse + 4)
{
    iTilfældigeTal[i] = iMindsteTalStørrelse;
}

for (int i = 0; i < iTilfældigeTal.Length; i++) 
{
    Console.Write("{0} ", iTilfældigeTal[i]);
}
Console.WriteLine();
int iSamledeVærdi = iTilfældigeTal[0] + iTilfældigeTal[1] + iTilfældigeTal[2] + iTilfældigeTal[3] + iTilfældigeTal[4] + iTilfældigeTal[5] + iTilfældigeTal[6] + iTilfældigeTal[7] + 
    iTilfældigeTal[8] + iTilfældigeTal[9];
int iSamledeVærdiGennemsnit = iSamledeVærdi / 10;
Console.WriteLine("Gennemsnit: {0}", iSamledeVærdiGennemsnit);
*/

//opgave 12.2
/*
Console.WriteLine("Tal: ");
int[] iTilfældigeTal = new int[10];


for (int i = 0; i < iTilfældigeTal.Length; i++)
{
    Console.Write("Indtast tal nr {0} -> ", i+1);
    iTilfældigeTal[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < iTilfældigeTal.Length; i++)
{
    Console.Write("{0} ", iTilfældigeTal[i]);
}
Console.WriteLine();
int iSamledeVærdi = iTilfældigeTal[0] + iTilfældigeTal[1] + iTilfældigeTal[2] + iTilfældigeTal[3] + iTilfældigeTal[4] + iTilfældigeTal[5] + iTilfældigeTal[6] + iTilfældigeTal[7] +
    iTilfældigeTal[8] + iTilfældigeTal[9];

double dSamledeVærdi = Convert.ToDouble(iSamledeVærdi);
int iSamledeVærdiGennemsnit = 0;

double dSamledeVærdiGennemsnit = Convert.ToDouble(iSamledeVærdiGennemsnit);
dSamledeVærdiGennemsnit = dSamledeVærdi / 10;
Console.WriteLine("Gennemsnit: {0}", dSamledeVærdiGennemsnit);
*/


//opgave 12.3 gjort til kommentar for at løse næste opgave.
/*
Console.WriteLine("Tal: ");
Console.Write("Venligst skriv antal af ønskede tal i array her -> ");
string sAntalØnskedeTalIArray = Console.ReadLine();
int iAntalØnskedeTalIArray = Convert.ToInt32(sAntalØnskedeTalIArray);
int[] iTilfældigeTal = new int[iAntalØnskedeTalIArray];

for (int i = 0; i < iTilfældigeTal.Length; i++)
{
    Console.Write("Indtast tal nr {0} -> ", i + 1);
    iTilfældigeTal[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < iTilfældigeTal.Length; i++)
{
    Console.Write("{0} ", iTilfældigeTal[i]);
}
Console.WriteLine();
int iSamledeVærdi = 0;
for (int i = 0; i < iAntalØnskedeTalIArray; i++)
{
    iSamledeVærdi = iSamledeVærdi + iTilfældigeTal[i];
}

double dSamledeVærdi = Convert.ToDouble(iSamledeVærdi);
int iSamledeVærdiGennemsnit = 0;
double dSamledeVærdiGennemsnit = Convert.ToDouble(iSamledeVærdiGennemsnit);

dSamledeVærdiGennemsnit = dSamledeVærdi / iAntalØnskedeTalIArray;
Console.WriteLine("Gennemsnit: {0}", dSamledeVærdiGennemsnit);
*/

//opgave 12.4
/*
//5.5
int iNum46 = 0;
Console.Write("Indtast 1 tal værdi her der skal ganges op. --> ");
string sNumPicker = Console.ReadLine();
int iNumPicker = Convert.ToInt32(sNumPicker);

Console.Write("Skriv venligst det antal man ønsker tallet skal ganges op med her -> ");
string sAntalTalSkalGanges = Console.ReadLine();
int iAntalTalSkalGanges = Convert.ToInt32(sAntalTalSkalGanges);

int[] iArrayTest = new int[iAntalTalSkalGanges];

for (int i = 0; i < iAntalTalSkalGanges; i++) 
{
    iArrayTest[i] = iNum46+iNum46;
}

skrivTalPåSkærm(iNum46, iNumPicker, iAntalTalSkalGanges);

static void skrivTalPåSkærm(int iNum46, int iNumPicker, int iAntalTalSkalGanges) 
{
do
{
    Console.Write(iNum46 + " ");
    iNum46 = iNum46 + iNumPicker;
} while (iNum46 < (iNumPicker * iAntalTalSkalGanges));
}
*/

//opgave 12.5
/*
string[] sBrugernavne = { "Benny", "Brian", "Jens", "Ronny", "Rolf" };
string[] sPasswords = { "kagekansmage", "storbilgodbil", "lidtblindtsind", "rickroll", "rolfrockerråt" };

string password = "";
int iAntalAfPasswordForsøg = 0;
bool bCorrectPasswordCombination = false;
while (bCorrectPasswordCombination == false && iAntalAfPasswordForsøg != 3)
{
    Console.Write("Skriv brugernavn her: -> ");
    string brugernavn = Console.ReadLine();
    if (brugernavn == "ok" || brugernavn == sBrugernavne[0] || brugernavn == sBrugernavne[1] || brugernavn == sBrugernavne[2] || brugernavn == sBrugernavne[3] || brugernavn == sBrugernavne[4])
    {
        Console.Write("Skriv password her: -> ");
        password = Console.ReadLine();
        if (password == "ok")
        {
            Console.WriteLine("ok");
        }
        else if (brugernavn == sBrugernavne[0] && password == sPasswords[0] || brugernavn == sBrugernavne[1] && password == sPasswords[1] || brugernavn == sBrugernavne[2] && password == sPasswords[2]
            || brugernavn == sBrugernavne[3] && password == sPasswords[3] || brugernavn == sBrugernavne[4] && password == sPasswords[4])
        {
            Console.WriteLine("Korrekt brugernavn og password kombination");
            bCorrectPasswordCombination = true;

        }
        else if (password != "ok" || brugernavn != sBrugernavne[0] && password != sPasswords[0] || brugernavn != sBrugernavne[1] && password != sPasswords[1]
            || brugernavn != sBrugernavne[2] && password != sPasswords[2] || brugernavn != sBrugernavne[3] && password != sPasswords[3] || brugernavn != sBrugernavne[4] && password != sPasswords[4]
            || iAntalAfPasswordForsøg != 3)
        {
            iAntalAfPasswordForsøg = iAntalAfPasswordForsøg + 1;
            Console.WriteLine("Denne kombination passer ikke. {0}/3 forsøg brugt.", iAntalAfPasswordForsøg);
        }
        else
        {
            Console.WriteLine("Brugernavn eller password forkert");
        }
    }

    else
    {
        Console.WriteLine("Brugernavn eller password forkert");
    }
}
*/
//prøv at inkludere et loop ved overstående.

//eget forsøg inden hjælp
/*
string[] sBrugernavne = { "Benny", "Brian", "Jens", "Ronny", "Rolf" };
string[] sPasswords = { "kagekansmage", "storbilgodbil", "lidtblindtsind", "rickroll", "rolfrockerråt" };

string sPassword = "";
int iAntalAfPasswordForsøg = 0;
bool bCorrectPasswordCombination = false;
bool bUserOk = false;
int iUserIndex = -1;
Console.Write("Skriv brugernavn her: -> ");
string sBrugernavn = Console.ReadLine();
for (int i = 0; i < sBrugernavne.Length; i++) 
    {
    if (sBrugernavn == sBrugernavne[i])
    {
        iUserIndex = 1;
        Console.WriteLine("Brugernavn ok.");
        Console.Write("Skriv password her -> ");
        sPassword = Console.ReadLine();
        if (sPassword == sPasswords[i])
        {
            Console.WriteLine("Password ok.");
        }
        else 
        {
            Console.WriteLine("Forkert password");
        }
    }
    else 
    {
        Console.WriteLine("Forkert brugernavn");
    }
    }
*/

//løsning. gjort til kommentar for at lave næste.
/*
string[] sBrugernavne = { "Benny", "Brian", "Jens", "Ronny", "Rolf" };
string[] sPasswords = { "kagekansmage", "storbilgodbil", "lidtblindtsind", "rickroll", "rolfrockerråt" };

string sPassword = "";
int iAntalAfPasswordForsøg = 0;
int iUserIndex = -1;
bool bRigtigNavnOgKodeKombination = false;
do
{
    Console.Write("Skriv brugernavn her: -> ");
    string sBrugernavn = Console.ReadLine();

    for (int i = 0; i < sBrugernavne.Length; i++)
    {
        if (sBrugernavn == sBrugernavne[i])
        {
            iUserIndex = i;
        }
    }
    if (iUserIndex != -1)
    {
        Console.Write("Skriv password her -> ");
        sPassword = Console.ReadLine();
        if (sPassword == sPasswords[iUserIndex])
        {
            Console.WriteLine("Brugernavn og password er OK!.");
            bRigtigNavnOgKodeKombination = true;
        }
        else
        {
            Console.WriteLine("Forkert password");
            Console.WriteLine("{0}/3 forsøg brugt", iAntalAfPasswordForsøg+1);
            iAntalAfPasswordForsøg = iAntalAfPasswordForsøg + 1;
        }
    }
    else
    {
        Console.WriteLine("Forkert brugernavn");
    }
} while (bRigtigNavnOgKodeKombination == false && iAntalAfPasswordForsøg < 3);

//et while loop er godt at bruge når koden det skal bruge er angivet over loops dekleration. Hvorimod et do while loop er brugbart når koden det skal bruge defineres inde imellem do while loopet.
//et for loop er godt med arrays eller lignende hvor man skal itere igennem adskillige værdier. Eller hvis man ved præcist hvor mange gange et loop burde køre.
//Et for loop skrives array declerationen.
*/


//opgave 12.6 gjort til kommentar for at løse næste ogpave.
/*
string[] sBrugernavne = { "Benny", "Brian", "Jens", "Ronny", "Rolf" };
string[] sPasswords = { "kagekansmage", "storbilgodbil", "lidtblindtsind", "rickroll", "rolfrockerråt" };

Console.WriteLine("Liste med brugernavne: ");
Console.WriteLine("Tast pågældende tal for at vælge brugernavn");

string sPassword = "";
int iAntalAfPasswordForsøg = 0;
int iUserIndex = -1;
bool bRigtigNavnOgKodeKombination = false;

passwordChecker(sBrugernavne, sPassword, iUserIndex, sPasswords, bRigtigNavnOgKodeKombination, iAntalAfPasswordForsøg);

 static void passwordChecker(string[] sBrugernavne, string sPassword, int iUserIndex, string[] sPasswords, bool bRigtigNavnOgKodeKombination, int iAntalAfPasswordForsøg) 
{
    do
    {
        for (int i = 0; i < sBrugernavne.Length; i++)
        {
            Console.WriteLine("{0} {1}", i, sBrugernavne[i]);
        }

        string sBrugernavn = Console.ReadLine();
        int iBrugernavn = Convert.ToInt32(sBrugernavn);
        sBrugernavn = sBrugernavne[iBrugernavn];

        for (int i = 0; i < sBrugernavne.Length; i++)
        {
            if (sBrugernavn == sBrugernavne[i])
            {
                iUserIndex = i;
            }
        }
        if (iUserIndex != -1)
        {
            Console.Write("Skriv password her -> ");
            sPassword = Console.ReadLine();
            if (sPassword == sPasswords[iUserIndex])
            {
                Console.WriteLine("Brugernavn og password er OK!.");
                bRigtigNavnOgKodeKombination = true;
            }
            else
            {
                Console.WriteLine("Forkert password");
                Console.WriteLine("{0}/3 forsøg brugt", iAntalAfPasswordForsøg + 1);
                iAntalAfPasswordForsøg = iAntalAfPasswordForsøg + 1;
            }
        }
        else
        {
            Console.WriteLine("Forkert brugernavn");
        }
    } while (bRigtigNavnOgKodeKombination == false && iAntalAfPasswordForsøg < 3);
}
*/

//opgave 12.7 gjort til kommentar for at løse næste opgave.
/*
//opgave 9.4
//meget hjælp fået. Forstod ikke helt. 

Console.Write("Skriv fulde navn her -> ");
string sBrugerNavn = Console.ReadLine();
string[] sArrayMedNavne = sBrugerNavn.Split(" ");
for (int i = 0; i < sArrayMedNavne.Length; i++) 
{
    Console.WriteLine("{0}", sArrayMedNavne[i]);
}
*/

//opgave 12.8 gjort til kommentar for at løse næste opgave.
/*
Console.Write("Indtast en sætning her som skal splittes ad. -> ");
string sBrugerString = Console.ReadLine();

string[] aSplittetBrugerString = sBrugerString.Split(" ");

for (int i = 0; i < aSplittetBrugerString.Length; i++) 
{
    Console.WriteLine("{0}", aSplittetBrugerString[i]);
}
*/

//opgave 12.9 gjort til kommentar for at løse næste opgave.
//opgave 12.8
/*
Console.Write("Indtast en sætning her som skal splittes ad. -> ");
string sBrugerString = Console.ReadLine();

string[] aSplittetBrugerString = sBrugerString.Split(" ");
int x = 1;
int y = 1;

for (int i = 0; i < aSplittetBrugerString.Length; i++, x += 2) 
{
//    Console.WriteLine("x");
 //   Console.SetCursorPosition(x+2,y+2);
    //Console.WriteLine("{0}", aSplittetBrugerString[i]);
    for (int iNy = 0; iNy < aSplittetBrugerString[i].Length; iNy++)
    {
        Console.SetCursorPosition(x, iNy+1);
        Console.WriteLine("{0}", aSplittetBrugerString[i][iNy]);
    } 
}
Console.ReadKey();
*/

//opgave 12.10
double dHjulDiameterBeggeSteder = 26.8;
//user input til antal hjul foran og bagved
Console.Write("Hvor mange tandhjul foran? -> ");
string sAntalTandhjulForan = Console.ReadLine();
int iAntalTandhjulForan = Convert.ToInt32(sAntalTandhjulForan);
int[] iTandhjulForan = new int[iAntalTandhjulForan];
int iForan = 0;

Console.Write("Hvor mange tandhjul bagved? -> ");
string sAntalTandhjulBagved = Console.ReadLine();
int iAntalTandhjulBagved = Convert.ToInt32(sAntalTandhjulBagved);
int[] iTandhjulBagved = new int[iAntalTandhjulBagved];
int iBagved = 0;

//user input til hjul størrelser
userInput(iForan, iTandhjulForan, iTandhjulBagved, iBagved);

//beregning af geartal
double dGearTal = (dHjulDiameterBeggeSteder * iTandhjulForan[0]) / iTandhjulBagved[0];
double[] aDMedGearTal = new double[iAntalTandhjulBagved];

//dispolay af output
userInputBeregnetTilGearTal(iTandhjulBagved, iTandhjulForan, aDMedGearTal, dHjulDiameterBeggeSteder);


//metoder
//Metode til at tage imod userInput.
static void userInput(int iForan, int[] iTandhjulForan, int[] iTandhjulBagved, int iBagved) 
{
    //user input til hjul størrelser
    Console.WriteLine("Indtast de forreste tandhjul");

    for (int i = 0; i < iTandhjulForan.Length; i++)
    {
        iForan = iForan + 1;
        Console.Write("Tandhjul {0} -> ", iForan);
        string sForresteTandhjul = Console.ReadLine();
        iTandhjulForan[i] = Convert.ToInt32(sForresteTandhjul);
    }

    Console.WriteLine("Indtast de bagerste tandhjul");

    for (int i = 0; i < iTandhjulBagved.Length; i++)
    {
        iBagved = iBagved + 1;
        Console.Write("Tandhjul {0} -> ", iBagved);
        string sBagersteTandhjul = Console.ReadLine();
        iTandhjulBagved[i] = Convert.ToInt32(sBagersteTandhjul);
    }
}

//Metode til at udregne gearl tal ud fra user Input.
static void userInputBeregnetTilGearTal(int[] iTandhjulBagved, int[] iTandhjulForan, double[] aDMedGearTal, double dHjulDiameterBeggeSteder) 
{
    //dispolay af output
    Console.Write("{0,17}", iTandhjulBagved[0]);
    for (int i = 1; i < iTandhjulBagved.Length; i++)
    {
        Console.Write("{0,10}", iTandhjulBagved[i]);
    }
    Console.WriteLine();


    Console.Write("{0,7} : ", iTandhjulForan[0]);
    for (int i = 0; i < aDMedGearTal.Length; i++)
    {
        aDMedGearTal[i] = (dHjulDiameterBeggeSteder * iTandhjulForan[0]) / iTandhjulBagved[i];
        Console.Write("{0,7:N1}" + "   ", aDMedGearTal[i]);
    }

    Console.WriteLine();

    for (int i = 1; i < iTandhjulForan.Length; i++)
    {
        Console.Write("{0,7} : ", iTandhjulForan[i]);
        for (int iNy = 0; iNy < aDMedGearTal.Length; iNy++)
        {
            aDMedGearTal[iNy] = (dHjulDiameterBeggeSteder * iTandhjulForan[i]) / iTandhjulBagved[iNy];
            Console.Write("{0,7:N1}" + "   ", aDMedGearTal[iNy]);
        }
        Console.WriteLine();
    }
}