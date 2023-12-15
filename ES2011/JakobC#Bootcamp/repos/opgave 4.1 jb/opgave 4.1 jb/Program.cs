using System.Threading;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//opgave 4.1

int i = 5;
do
{
    i = i + 1;
    Console.WriteLine(i);
} while (i < 5);

i = 5;
while (i < 5)
{
    i = i + 1;
    Console.WriteLine(i);
}

/*output: 6 */

//4.2
int x = 10;
int y = 62;
while (x < 21) {
    Console.SetCursorPosition(x, y);
    Console.Write("*");
    Console.SetCursorPosition(x-1, y+1);
    Console.Write("*o*");
    Console.SetCursorPosition(x - 2, y + 2);
    Console.Write("*ooo*");
    Console.SetCursorPosition(x-3, y+3);
    Console.Write("*ooooo*");
    Console.SetCursorPosition(x-4,y+4);
    Console.Write("*********");
    Console.SetCursorPosition(x, y+5);
    Console.Write("*");
    Console.WriteLine();
    Console.ReadKey();
        x = x + 10;
    }


/*
//4.3
x = 0;
y = 72;
while (x < 13) { 
    //4.4 part 1
    Thread.Sleep(500);
    x = x + 1;
    Console.SetCursorPosition(x, y);
    Console.Write("X");
}

while (y < 75) {    
    //4.4 part 1
    Thread.Sleep(500);
    x = 13;
    Console.SetCursorPosition(x, y+1);
    Console.Write("X");
    y = y + 1;
}

while (x > 1) {
    //4.4 part 1
    Thread.Sleep(500);
    x = x - 1;
    Console.SetCursorPosition(x, y);
    Console.Write("X");
}

while (y > 73) {
    //4.4 part 1
    Thread.Sleep(500);
    x = 1;
    Console.SetCursorPosition(x, y-1);
    Console.Write("X");
    y = y - 1;
}
*/

//ogpave 4.5
x = 1;
y = 80;
Console.SetCursorPosition(x, y);
int sleeper = 10;
Console.Write("╔");

while (x < 13) { 
    //4.4 part 1
    Thread.Sleep(sleeper);
    x = x + 1;
    Console.SetCursorPosition(x, y);
    Console.Write("═");
}

x = 13;
Console.Write("╗");

while (y < 82) {    
    //4.4 part 1
    Thread.Sleep(sleeper);
    x = 14;
    Console.SetCursorPosition(x, y+1);
    Console.Write("║");
    y = y + 1;
}

y = 83;
Console.SetCursorPosition(x, y);
Console.Write("╝");

while (x > 2) {
    //4.4 part 1
    Thread.Sleep(sleeper);
    x = x - 1;
    Console.SetCursorPosition(x, y);
    Console.Write("═");
}

x = 1;
Console.SetCursorPosition(x, y);
Console.Write("╚");


while (y > 81) {
    //4.4 part 1
    Thread.Sleep(sleeper);
    x = 1;
    Console.SetCursorPosition(x, y-1);
    Console.Write("║");
    y = y - 1;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

//4.6
int num46 = 0;
do {
    num46 = num46 + 1;
    Console.Write(num46 + " ");
} while (num46 < 20);
Console.WriteLine();

//4.7
num46 = 20;
do {
    Console.Write(num46 + " ");
    num46 = num46 - 1;
} while (num46 > 0);
Console.WriteLine();

//4.8

num46 = 2;
do {
    Console.Write(num46 + " ");
    num46 = num46 + 2;
} while (num46 < 21);