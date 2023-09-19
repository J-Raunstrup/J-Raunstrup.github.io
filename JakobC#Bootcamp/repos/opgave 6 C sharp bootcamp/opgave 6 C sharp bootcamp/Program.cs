// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
/* commented out so next assignment can be completed.
//6.1 lav variabler
Console.Write("First name: ");
string firstName = Console.ReadLine();
Console.Write("Last name: ");
string lastName = Console.ReadLine();
string name = firstName + " " + lastName; 
string address = Console.ReadLine();
string phone = Console.ReadLine();
string personInfo = name + address + phone;
Console.Clear();
Console.SetCursorPosition(5, 5);
Console.Write(personInfo);
// 6.1 lav metode 

placeFourStars(personInfo);

static void placeFourStars(string personInfo)
{
    Console.SetCursorPosition(14, 4);
    Console.Write("*");
    Console.SetCursorPosition(5, 5);
    Console.Write("* " + personInfo + " *");
    Console.SetCursorPosition(14, 6);
    Console.Write("*");
    return ;
}
*/

/*
// 6.2 commented out so next assignment can be done.
//5.1 commented out so next assignemnt can be tried.
Console.Write("First name: ");
string firstName = Console.ReadLine() + " ";
Console.Write("Last name: ");
string lastName = Console.ReadLine() + " ";
string name = firstName + lastName;
Console.Write("Adress: ");
string address = Console.ReadLine() + " ";
Console.Write("Phone: ");
string phone = Console.ReadLine() + " ";
string personInfo = name + address + phone;
Console.Write(personInfo);
Console.WriteLine();
Console.ReadKey();
fullName(firstName, lastName);

static void fullName(string firstName, string lastName)
{
    Console.WriteLine(firstName + lastName);
}


//6.3 commented out so next assignment can be done.
Console.Write("Skriv 2 tal i alt. Første tal her 1/2 -> ");
string sUserInput1 = Console.ReadLine();
Console.Write("Skriv 2 tal i alt. Andet tal her 2/2 -> ");
string sUserInput2 = Console.ReadLine();
double dUserInput1 = Convert.ToDouble(sUserInput1);
double dUserInput2 = Convert.ToDouble(sUserInput2);
userInputCalculator(dUserInput1, dUserInput2);
static void userInputCalculator(double dUserInput1, double dUserInput2)
{
    Console.WriteLine(dUserInput1 + dUserInput2);
}
*/




//6.4 commented out so next assignment can be done.
/*int xstart = 1;
int xstop = 13;
int ystart = 80;
int ystop = 82;

makeABox(xstart, xstop, ystart, ystop);

static void makeABox(int xstart, int xstop, int ystart, int ystop)
{
    //ogpave 4.5
    int x = xstart;
    int y = ystart;
    Console.SetCursorPosition(x, y);
    int sleeper = 10;
    Console.Write("╔");

    while (x < xstop)
    {
        //4.4 part 1
        Thread.Sleep(sleeper);
        x = x + 1;
        Console.SetCursorPosition(x, y);
        Console.Write("═");
    }

    x = x + 1;
    Console.Write("╗");

    while (y < ystop)
    {
        //4.4 part 1
        Thread.Sleep(sleeper);
        Console.SetCursorPosition(x, y + 1);
        Console.Write("║");
        y = y + 1;
    }

    y = ystop+1;
    Console.SetCursorPosition(x, y);
    Console.Write("╝");

    while (x > xstart)
    {
        //4.4 part 1
        Thread.Sleep(sleeper);
        x = x - 1;
        Console.SetCursorPosition(x, y);
        Console.Write("═");
    }


    Console.SetCursorPosition(x, y);
    Console.Write("╚");


    while (y > ystart+1)
    {
        //4.4 part 1
        Thread.Sleep(sleeper);
        Console.SetCursorPosition(x, y - 1);
        Console.Write("║");
        y = y - 1;
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}
*/

// commented out so next assignment can be done.
//6.6
int userBoxes = 0;
Console.Write("Please type number of wished boxes --> ");
string sUserAnswer = Console.ReadLine();
int iUserAnswer = Convert.ToInt32(sUserAnswer);
Console.Write("Please type how much smaller each box should be in increments --> ");
string sUserBoxSizeWish = Console.ReadLine();
int iUserBoxSize = Convert.ToInt32(sUserBoxSizeWish);
int xstart = 1;
int xstop = 100;
int ystart = 80;
int ystop = 105;
while (userBoxes < iUserAnswer)
{
    makeThreeBoxes(xstart, xstop, ystart, ystop);
    userBoxes = userBoxes + 1;
    xstart = xstart + iUserBoxSize;
    xstop = xstop - iUserBoxSize;
    ystart = ystart + iUserBoxSize;
    ystop = ystop - iUserBoxSize;
    //6.5
}


static void makeThreeBoxes(int xstart, int xstop, int ystart, int ystop)
{
    //ogpave 4.5
    int x = xstart;
    int y = ystart;
    Console.SetCursorPosition(x, y);
    int sleeper = 10;
    Console.Write("╔");

    while (x < xstop)
    {
        //4.4 part 1
        Thread.Sleep(sleeper);
        x = x + 1;
        Console.SetCursorPosition(x, y);
        Console.Write("═");
    }

    x = x + 1;
    Console.Write("╗");

    while (y < ystop)
    {
        //4.4 part 1
        Thread.Sleep(sleeper);
        Console.SetCursorPosition(x, y + 1);
        Console.Write("║");
        y = y + 1;
    }

    y = ystop + 1;
    Console.SetCursorPosition(x, y);
    Console.Write("╝");

    while (x > xstart)
    {
        //4.4 part 1
        Thread.Sleep(sleeper);
        x = x - 1;
        Console.SetCursorPosition(x, y);
        Console.Write("═");
    }


    Console.SetCursorPosition(x, y);
    Console.Write("╚");


    while (y > ystart + 1)
    {
        //4.4 part 1
        Thread.Sleep(sleeper);
        Console.SetCursorPosition(x, y - 1);
        Console.Write("║");
        y = y - 1;
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}

Console.ReadKey();
Console.SetCursorPosition(0, 110);


//6.7

//6.3
/*
Console.Write("Skriv 2 tal i alt. Første tal her 1/2 -> ");
string sUserInput1 = Console.ReadLine();
Console.Write("Skriv 2 tal i alt. Andet tal her 2/2 -> ");
string sUserInput2 = Console.ReadLine();
double dUserInput1 = Convert.ToDouble(sUserInput1);
double dUserInput2 = Convert.ToDouble(sUserInput2);
userInputCalculator(dUserInput1, dUserInput2);
static void userInputCalculator(double dUserInput1, double dUserInput2)
{
    Console.WriteLine(dUserInput1 + dUserInput2);
}
*/

//6.3
/*number input registering. working. number sum calculator throughtout working.*/
/*
int iNuværendeAntalTal = 0;
Console.Write("Skriv ønskede antal tal i alt her -> ");
string sAntalTal = Console.ReadLine();
int iAntalTal = Convert.ToInt32(sAntalTal);
double dNuværendeVærdi = 0;

while (iAntalTal > iNuværendeAntalTal)
{
    Console.Write("Skriv et tal her " + (iNuværendeAntalTal + 1) + "/" + iAntalTal + " -> ");
    iNuværendeAntalTal = iNuværendeAntalTal + 1;
    dNuværendeVærdi = returnSum(dNuværendeVærdi);
}
// function missing. average missing.
double dAntalTal = Convert.ToDouble(iAntalTal);
double dGennemsnit = udregnGennemsnit(dAntalTal, dNuværendeVærdi);
Console.WriteLine(dGennemsnit);

static double udregnGennemsnit(double dAntalTal, double dNuværendeVærdi) 
{
    double dGennemsnitAfTal = dNuværendeVærdi / dAntalTal;
    return dGennemsnitAfTal;
}

/*
userInputCalculator(dUserInput1, dUserInput2);
static void userInputCalculator(double dUserInput1, double dUserInput2)
{
    Console.WriteLine(dUserInput1 + dUserInput2);
}
*/
/*
static double returnSum(double dNuværendeVærdi)
{
    string sUserInput = Console.ReadLine();
    double dUserInput = Convert.ToDouble(sUserInput);
    double dnyNuværendeVærdi = dNuværendeVærdi + dUserInput;
    Console.WriteLine("Nuværende sum af indtastede tal. -> " + dNuværendeVærdi);
    return dnyNuværendeVærdi;
}

*/