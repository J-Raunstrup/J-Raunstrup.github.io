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



int startBankBalance = 1000;

int bankBalance = startBankBalance;

//int[] listeMedTal = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
//tilføj pladser eller tal.

Console.WriteLine("Welcome to casino 'The House Always Wins' says a mand at the entrance.");
Console.WriteLine("You walk a little forwards. The roulette machine calls out to you. It says: 'Please play with me'");
Console.WriteLine("Intrigued by the voice you start walking towards the roulette machine. On the machine you see a screen where you can choose between different betting types.");
Console.WriteLine();


do
{
    string variableForBetType = bettingMenu();

    int[] listWithNumbers = receiveBetType(variableForBetType);

    int variableToReceiveBettingAmount = receiveBetAmount(bankBalance);

    int randomNumber = returnARandomNumber();

    bool jackpotOrNot = compareRandomNumberWithUserBet(listWithNumbers, randomNumber);

    int variableToJackpotCalculation = calculateJackpot(jackpotOrNot, variableForBetType, variableToReceiveBettingAmount);

    bankBalance = updateBankBalance(bankBalance, variableToJackpotCalculation);
} while (playAgain(bankBalance) != false);



static string bettingMenu() 
{
    //vis liste med bettingstyper. med 1 tal foran hver mulighed der tilsvarer til hver mulighed.
    Console.WriteLine("Betting menu");
    Console.WriteLine("Please choose a bet type from the list below");
    Console.WriteLine("1: Group with red numbers");
    Console.WriteLine("2: Group with black numbers");
    Console.WriteLine("3: Group with numbers 1 through 18");
    Console.WriteLine("4: Group with numbers 19 through 36");
    Console.WriteLine("5: Group with uneven numbers");
    Console.WriteLine("6: Group with even numbers");
    Console.WriteLine("7: A single number");
    Console.WriteLine();
    Console.Write("Please write answer here (1/2/3/4/5/6/7) -> ");

    string receiveBetType = Console.ReadLine();
    return receiveBetType;
}

static int receiveBetAmount(int bankBalance)
{
    //modtag indtastning. gør det til int. derefter retuner.
    Console.Write("How much money do you want to bet? Current balance is {0}. -> ", bankBalance);
    string userBetAmount = Console.ReadLine();
    Console.WriteLine();
    int userBetAmountInt = Convert.ToInt32(userBetAmount);
    if (userBetAmountInt > bankBalance)
    {
        Console.WriteLine("The bet amount of {0} cant be placed since its more than the bank accounts balance of {1}.", userBetAmountInt, bankBalance);
        return 0;
    }
    else 
    {
        Console.WriteLine("The bet amount of {0} has been received.", userBetAmountInt);
        Console.WriteLine("The wheel began spinning");
        return userBetAmountInt;
    }
}

static int returnARandomNumber()
{
    //ruller et tilfældigt tal fra 0 til 37 og retunerer derefter det tal.
    Random rand = new Random();
    int randomNumber = rand.Next(0, 36);
    Console.WriteLine("A random number was rolled. The rolled number is: {0}", randomNumber);
    return randomNumber;
}

static int[] receiveBetType(string variableForBetType)
{
    int[] redNumbers = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
    int[] blackNumbers = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
    int[] emptyArray = { };

    //array loop til 1-18 array
    int[] numbers1Through18 = new int[18];
    int smallestNumber = 0;
    for (int i = 0; i < numbers1Through18.Length; i++)
    {
        smallestNumber = smallestNumber + 1;
        numbers1Through18[i] = smallestNumber;
    }

    //array loop til 19-36 array
    int[] numbers19Through36 = new int[18];
    smallestNumber = 18;
    for (int i = 0; i < numbers1Through18.Length; i++)
    {
        smallestNumber = smallestNumber + 1;
        numbers19Through36[i] = smallestNumber;
    }

    //array loop til ulige tal.
    int[] unevenNumbers = new int[18];
    smallestNumber = -1;
    for (int i = 0; i < unevenNumbers.Length; i++)
    {
        smallestNumber = smallestNumber + 2;
        unevenNumbers[i] = smallestNumber;
    }

    //array loop til lige tal.
    int[] evenNumbers = new int[18];
    smallestNumber = 0;
    for (int i = 0; i < evenNumbers.Length; i++)
    {
        smallestNumber = smallestNumber + 2;
        evenNumbers[i] = smallestNumber;
    }

    //definering af enkelttalsarray
    int[] aSingleNumber = new int[1];

    if (variableForBetType == "1")
    {
        return redNumbers;
    }
    else if (variableForBetType == "2")
    {
        return blackNumbers;
    }
    else if (variableForBetType == "3")
    {
        return numbers1Through18;
    }
    else if (variableForBetType == "4")
    {
        return numbers19Through36;
    }
    else if (variableForBetType == "5")
    {
        return unevenNumbers;
    }
    else if (variableForBetType == "6")
    {
        return evenNumbers;
    }
    else if (variableForBetType == "7") 
    {
        Console.Write("Select a single number between 1 and 36 to bet on. Write the number here -> ");
        string smallestNumberString = Console.ReadLine();
        int smallestNumberInt = Convert.ToInt32(smallestNumberString);
        aSingleNumber[0] = smallestNumberInt;
        return aSingleNumber;
    }
    else
    {
        Console.WriteLine("Unknown answer");
        return emptyArray;
    }
}

//skal mere tilføjes under denne f.eks. ved tilfædlgittla så denne bliver til random tal i stedet eller burde det stadig virke?
static bool compareRandomNumberWithUserBet(int []listWithNumbers, int randomNumber)
{
    //sammenligner "returnEtTilfældigtTal" med "modtagBetUndertype"
    for (int i = 0; i < listWithNumbers.Length; i++)
    {
        if (listWithNumbers[i] == randomNumber)
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

static int calculateJackpot(bool jackpotOrNot, string variableForBetType, int variableToReceiveBettingAmount) 
{
    if (jackpotOrNot == false)
    {
        Console.WriteLine("You lost. The bank balance has been updated");
        return 0 - variableToReceiveBettingAmount;
    }
    else
    {
        Console.WriteLine("There's jackpot! The bank balance has been updated");
        if (variableForBetType == "1" || variableForBetType == "2" || variableForBetType == "3" || variableForBetType == "4" || variableForBetType == "5" || variableForBetType == "6")
        {
            return 2 * variableToReceiveBettingAmount;
        }
        else if (variableForBetType == "7")
        {
            return 35 * variableToReceiveBettingAmount;
        }
        else
        {
            Console.WriteLine("Error");
            return 0;
        }
    }
}

static int updateBankBalance(int bankBalance, int variableToJackpotCalculation)
{
    //bruger saldo til at minuses med "modtagBetBeløb" eller ganges med odsne vinningen. som f.eks. er *35 ved rigtigt gæt på et enkelt tal. Måske returner den også saldo. bare
    //den opdaterede version.

    Console.WriteLine("The new bank balance is {0}", bankBalance + variableToJackpotCalculation);
    return bankBalance + variableToJackpotCalculation;
}

static bool playAgain(int bankBalance)
{
    //looper alle de andre metoder igennem igen hvis svaret til spil igne er ja med en opdateret saldo. Hvis bruger beløb bliver 0 kan der ikke spilles igne medmindre
    //programmet genstartes. Ellers stopper programmet.
    Console.Write("Play again? (J/N) -> ");
    string vilBrugerSpilleIgen = Console.ReadLine();
    if (vilBrugerSpilleIgen == "j" || vilBrugerSpilleIgen == "J" && bankBalance > 0)
    {
        Console.WriteLine("The answer was yes. The program will be repeated");
        Console.Clear();
        return true;
    }
    else if (vilBrugerSpilleIgen == "j" || vilBrugerSpilleIgen == "J" && bankBalance <= 0)
    {
        Console.WriteLine("There are no more money to bet. The program will be stopped");
        return false;
    }
    else
    {
        Console.WriteLine("The answer was no. The program will stop.");
        return false;
    }
}