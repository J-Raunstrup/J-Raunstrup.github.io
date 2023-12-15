// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//opgave 10.1
/*
string sVare = "Vare";
string sStk = "stk";
string sPris = "Pris";
string sPrisIAlt = "Pris ialt";
Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5}", sVare, sStk, sPris, sPrisIAlt);
string sVare1 = "Cola";
string sVare2 = "Pizza";
string sVare3 = "Mayo";
string sVare4 = "Ialt";
int iStk1 = 3;
int iStk2 = 2;
int iStk3 = 1;
string sStk4 = "";
int iPris1 = 14;
int iPris2 = 45;
int iPris3 = 5;
string sPris4 = "";
double dPrisIAlt1 = iStk1*iPris1;
double dPrisIAlt2 = iStk2 * iPris2;
double dPrisIAlt3 = iStk3 * iPris3;
double dPrisIAlt4 = dPrisIAlt1+dPrisIAlt2+dPrisIAlt3;
Console.WriteLine("{0,-5} {1,3} {2,6} {3,10:N2}", sVare1, iStk1, iPris1, dPrisIAlt1);
Console.WriteLine("{0,-5} {1,3} {2,6} {3,10:N2}", sVare2, iStk2, iPris2, dPrisIAlt2);
Console.WriteLine("{0,-5} {1,3} {2,6} {3,10:N2}", sVare3, iStk3, iPris3, dPrisIAlt3);
Console.WriteLine("{0,-5} {1,3} {2,6} {3,10:N2}", sVare4, sStk4, sPris4, dPrisIAlt4);
*/

//opgave 10.2
int numberOfFriends = 5;
Console.WriteLine("Antal af venner: {0}", numberOfFriends);
Console.WriteLine();

int numberOfBeers = 20;
Console.WriteLine("Antal af øl: {0}", numberOfBeers);
int numberOfBeersPerPerson = numberOfBeers / numberOfFriends;
Console.WriteLine("Antal af øl per person: {0}", numberOfBeersPerPerson);
Console.WriteLine();

double prizePerBeer = 6.75;
Console.WriteLine("Pris per øl: {0}", prizePerBeer);
double amountPerPerson = prizePerBeer * numberOfBeersPerPerson;
Console.WriteLine("Pris per person for øl før tilbud: {0}", amountPerPerson);
Console.WriteLine();

double discountPerPerson = 1.25;
amountPerPerson = amountPerPerson - discountPerPerson;
Console.WriteLine("Pris per person for øl efter tilbud: {0}", amountPerPerson);
Console.WriteLine();