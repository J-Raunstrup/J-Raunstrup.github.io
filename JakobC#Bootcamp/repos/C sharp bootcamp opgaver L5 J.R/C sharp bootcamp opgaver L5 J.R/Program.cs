// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//5.1 commented out so next assignemnt can be tried.
Console.Write("First name: ");
string firstName = "First name: " + Console.ReadLine() + " ";
Console.Write("Last name: ");
string lastName = "Last name: " + Console.ReadLine() + " ";
string name = firstName + lastName;
Console.Write("Adress: ");
string address = "Address: " + Console.ReadLine() + " ";
Console.Write("Phone: ");
string phone = "Phone: " + Console.ReadLine() + " ";
string personInfo = name + address + phone;
Console.Write(personInfo);
Console.WriteLine();
Console.ReadKey();

//5.2
/*
Console.Write("Fullname: ");
string fullName = Console.ReadLine();
while (fullName != null) {
    Console.ReadLine();
    Console.WriteLine(fullName);
}
*/
/*
Console.Write("Full name: ");
string fullName = "Full name: " + Console.ReadLine();
string manyName = Console.ReadLine();
while (manyName != null) {
    Console.ReadLine();
    Console.Write("done");
};
*/

// right answer below this.
string input = "";
string fullName = "";
Console.Write("Name: ");
fullName = Console.ReadLine();
do
{
    Console.Write("Name: ");
    input = Console.ReadLine();
    fullName = fullName + " " + input;
} while (input != "");
Console.Clear();
Console.Write("Fullname:");
Console.WriteLine(fullName);

//5.3
/*
//assignment 3.3 lav et program der ligger 3 tal sammen og beregner gennemsnittet. Derefter print til skærm.
Console.WriteLine();
int number1 = 4;
int number2 = 13;
int number3 = 7;
int programCalculator = (number1 + number2 + number3) / 3;
//written in console to show how the result is calculated.
Console.WriteLine("int programCalculator = (number1 + number2 + number3) / 3;");
Console.WriteLine(programCalculator);
*/

//5.3
Console.WriteLine();
Console.Write("Indtast 1 tal. (step 1/3) --> ");
string sTal1 = Console.ReadLine();
Console.Write("Indtast 1 tal. (step 2/3) --> ");
string sTal2 = Console.ReadLine();
Console.Write("Indtast 1 tal. (step 3/3) --> ");
string sTal3 = Console.ReadLine();

//5.4
double dTal1 = Convert.ToInt32(sTal1);
double dTal2 = Convert.ToInt32(sTal2);
double dTal3 = Convert.ToInt32(sTal3);

//hvorfor skal jeg bruge et loop? lidt forvirret.
double talResultatAf3 = (dTal1 + dTal2 + dTal3) / 3; 
Console.WriteLine(talResultatAf3);

//5.5
int num46 = 0;
Console.Write("Indtast 1 tal værdi her der skal ganges op. --> ");
string sNumPicker = Console.ReadLine();
int dNumPicker = Convert.ToInt32(sNumPicker);
do
{
    Console.Write(num46 + " ");
    num46 = num46 + dNumPicker;
} while (num46 < (dNumPicker*11));