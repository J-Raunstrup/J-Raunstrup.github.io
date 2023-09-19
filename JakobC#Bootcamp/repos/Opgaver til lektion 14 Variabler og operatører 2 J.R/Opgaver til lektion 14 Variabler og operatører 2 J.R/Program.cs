// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//opgave 14.1 gjort til kommentar for at løse næste opgave.
//kopieret fra opgave formulering:
/*
// Fødselsdag d 15 juli 1999
DateTime birthdate = new DateTime(1999, 7, 15);
// Dato og tid her og nu
DateTime now = DateTime.Now;

int age = now.Year - birthdate.Year;
Console.WriteLine("age = {0}", age);
*/

//eget svar
/*
// Fødselsdag d 15 juli 1999
DateTime birthdate = new DateTime(1999, 7, 15);
// Dato og tid her og nu
DateTime now = DateTime.Now;
TimeSpan lifeLength = now - birthdate;
int age = lifeLength.Days / 365;
Console.WriteLine("age = {0}", age);
*/

//opgave 14.2
//opgave 14.1
//ny tilføjelse start


//ny tilføjelse slut
Console.Write("Skriv CPR her -> ");
string sBrugerCPR = Console.ReadLine();

menuTilCprMedKøn(sBrugerCPR);

//sæt cpr = birthdate
string sSubStringAfsBrugerCPRDag = sBrugerCPR.Substring(0, 2);
Console.WriteLine(sSubStringAfsBrugerCPRDag);
int iSubStringAfsBrugerCPRDag = Convert.ToInt32(sSubStringAfsBrugerCPRDag);

string sSubStringAfsBrugerCPRMåned = sBrugerCPR.Substring(2, 2);
Console.WriteLine(sSubStringAfsBrugerCPRMåned);
int iSubStringAfsBrugerCPRMåned = Convert.ToInt32(sSubStringAfsBrugerCPRMåned);

string sSubStringAfsBrugerCPRÅr = sBrugerCPR.Substring(4, 2);
Console.WriteLine(sSubStringAfsBrugerCPRÅr);
int iSubStringAfsBrugerCPRÅr = Convert.ToInt32(sSubStringAfsBrugerCPRÅr);

if (iSubStringAfsBrugerCPRÅr <= 23)
{
    iSubStringAfsBrugerCPRÅr = iSubStringAfsBrugerCPRÅr + 2000;
}
else if (iSubStringAfsBrugerCPRÅr > 23)
{
    iSubStringAfsBrugerCPRÅr = iSubStringAfsBrugerCPRÅr + 1900;
}
else 
{
    Console.WriteLine("Error with years");
}

CPRUdregner(iSubStringAfsBrugerCPRÅr, iSubStringAfsBrugerCPRMåned, iSubStringAfsBrugerCPRDag);



static void menuTilCprMedKøn(string sBrugerCPR) 
{
    char cBrugerCPRSidsteTegn = sBrugerCPR[sBrugerCPR.Length - 1];

    string sBrugerCPRSidsteTegn = Convert.ToString(cBrugerCPRSidsteTegn);
    int iBrugerCPRSidsteTegn = Convert.ToInt32(sBrugerCPRSidsteTegn);

    Console.WriteLine(iBrugerCPRSidsteTegn);
    int iMandEllerKvinde = iBrugerCPRSidsteTegn % 2;
    Console.WriteLine(iMandEllerKvinde);

    if (iMandEllerKvinde == 0)
    {
        Console.WriteLine("Kvinde");
    }
    else if (iMandEllerKvinde == 1)
    {
        Console.WriteLine("Mand");
    }
    else
    {
        Console.WriteLine("Ukendt køn eller værdi.");
    }
}

static void CPRUdregner(int iSubStringAfsBrugerCPRÅr, int iSubStringAfsBrugerCPRMåned, int iSubStringAfsBrugerCPRDag) 
{
    // Fødselsdag d 15 juli 1999
    DateTime birthdate = new DateTime(iSubStringAfsBrugerCPRÅr, iSubStringAfsBrugerCPRMåned, iSubStringAfsBrugerCPRDag);
    // Dato og tid her og nu
    DateTime now = DateTime.Now;
    TimeSpan lifeLength = now - birthdate;
    int age = lifeLength.Days / 365;
    Console.WriteLine("age = {0}", age);
}