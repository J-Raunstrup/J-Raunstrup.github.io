// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//INPUT, UDREGNING OUTPUT.

//UDREGNING. HVOR MANGE SKUD. HVOR STOR ET MAGASIN



input();

string sAntalSkud = Console.ReadLine();
int iAntalSkud = Convert.ToInt32(sAntalSkud);

Console.Write("SKRIV STØRRELSE PÅ TRUMLEN. -> ");
string sBestemTrumleStørrelse = Console.ReadLine();
int iBestemTrumleStørrelse = Convert.ToInt32(sBestemTrumleStørrelse);

int[] iSkudITrumle = new int[iBestemTrumleStørrelse];
Console.WriteLine("TRUMLEN RULLES IGENNEM");
for (int i = 0; i < iAntalSkud; i++)
{
    iSkudITrumle[i] = 1;
}
//her burde antallet af pistolskud overføres til arrayet,
Console.WriteLine("TRUMLEN STOPPEDE MED AT SPINNE RUNDT. PISTOLEN ER KLAR");

skydPistolen(iBestemTrumleStørrelse, iAntalSkud, iSkudITrumle);



static void input() 
{
    Console.WriteLine("VELKOMMEN TIL DET ULTIMATIVE SPIL");
    Console.WriteLine("NAVNET PÅ SPILLET ER RUSSISK ROULETTE");
    Console.Write("VÆLG HVOR MANGE SKUD DER SKAL SÆTTES I. KUN I TAL. -> ");
}



static string skydPistolen(int iBestemTrumleStørrelse, int iAntalSkud, int[] iSkudITrumle)
{
    Console.Write("SKYD PISTOLEN? (J/N) -> ");
    string sSkalPistolenSkydes = Console.ReadLine();
    if (sSkalPistolenSkydes == "J" || sSkalPistolenSkydes == "j")
    {
        //skriv kald efter metode for trumle tjek her.
        Random rand = new Random();
        int random1 = rand.Next(iBestemTrumleStørrelse);
        //skal tjekke tal fundet om det er 1 eller 0 i array.
        int dødEllerILive = iSkudITrumle[rand.Next(iBestemTrumleStørrelse)];
        if (dødEllerILive == 1)
        {
            Console.WriteLine("BANG! DU DØDE");
        }
        else if (dødEllerILive == 0)
        {
            Console.WriteLine("DER VAR INTET SKUD. PUTIN VILLE VÆRE SKUFFET.");
        }
        else
        {
            Console.WriteLine("FEJL. UKENDT UDFALD.");
        }

    }
    else if (sSkalPistolenSkydes == "N" || sSkalPistolenSkydes == "n")
    {
        Console.WriteLine("DER BLEV BAKKET UD. PROGRAMMET STOPPES");
    }
    else
    {
        Console.WriteLine(sSkalPistolenSkydes + " ER ET UKENDT SVAR");
    }
    return sSkalPistolenSkydes;
}

//done godkendt af jakob