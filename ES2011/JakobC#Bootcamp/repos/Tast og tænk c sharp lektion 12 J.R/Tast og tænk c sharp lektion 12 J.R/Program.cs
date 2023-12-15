// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//opgave M12.1
/*
int[] numbers = { 11, 3, 6, 37, 5 };
Console.WriteLine("Arrayet numbers har {0} pladser", numbers.Length);
for (int i = 0; i < numbers.Length; i++) 
{
    Console.WriteLine("På plads no. {0} er tallet {1}", i, numbers[i]);
}
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//Kør programmet. Hvad gør det?
//det skaber en array der hedder numbers med adskillige værdier. Derefter skriver den hvoir mange indtastede nummer pladser der er med numbers.Length.
//Efter dette så skabes et for loop hvor i er = 0. Efter dette fortæller vi loopet det skal køre så læng ei er mindre end numbers.length. imens dette er sandt så skal i pludses med 1 hver gang inden programmet kører igen.
//Efter dette så beskriver vi hvert plads og hvilket tal der er på hver plads i arrayen. Dette sker fordi i pludses op en gang hver gang loopet kører.
//Dermed bliver indexet en højere hver gang indtil vi har nået enden af number.Length. Her oplyser i hvilken plads i arrayen vi er på og numbers[i] oplyser ´tal værdien for den plads i arrayen.
//Derefter fortælles brugeren de skal trykke på en tast for at afslutte programmet med en readkey commando efterfulgt.

/* Prøv at ændre linjen  int[] numbers = { 11, 3, 6, 37, 5 }; til 
int[] numbers = { 11, 3, 6, 37, 5, 88 }; Kør programmet! Hvad ændrede sig?
*/

/*
int[] numbers = { 11, 3, 6, 37, 5, 88 };
Console.WriteLine("Arrayet numbers har {0} pladser", numbers.Length);
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("På plads no. {0} er tallet {1}", i, numbers[i]);
}
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

// det der ændrede sig var at fordi denne kode er dynamisk så kan vi ændre antallet af pladserne og værdierne i arrayen og dermed vil outputtet være anderledes. Denne gang var der altså en ekstra linje
// som beskrev at der var tallet 88 på plads 5. Dette kan lade sig gøre fordi vi bruger variablerne til at outputte vores resultat. Hvade vi outputtet værdier direkte ville dette ikke kunne lade sig gøre.
// Derudover fordi variablerne er i et loop vil loopet kigge hele vores array igennem og derefter outputte dette til konsollen.

//Hvilke positioner har første og sidste plads i arrayet “numbers”?
//svar: 0 og numbers.Length-1 eller i dette tilfælde 5. dog generelt numbers.Length-1 tror jeg? bliver lidt forvirret nogle gange på numbers.Length og numbers.Length-1.

//Hvad er forholdet mellem sidste position og arrayets længde?
//svar: den sidste position er en mindre end arrayets længde da positionerne refererer ofte til index hvorimod længdne af arrayet er anderledes og bruger det typiske antal af tegn hvorimod index eller position
//bruger antal tegn -1. tror jeg? er dog ikke sikker?



//opgave M12.2 gjort til kommentar for at løse næste opgave.
/*
string[] names = new string[3];
names[0] = "Anton";
names[1] = "Benny";
names[2] = "Claus";
for (int i = 0; i < names.Length; i++) 
{
    Console.WriteLine("På plads no. {0} er navnet {1}", i, names[i]);
}
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//Kør programmet. Hvad gør det?
//svar: det laver en array kaldet names med typen string. Derefter skaber den 3 pladser af strings inde i denne array. Derefter angives hver plads i denne array en string værdi med. Hver string værdi i dette tilfælde er et
//forskelligt navn. Derefter skabes et loop hvor variablen i sættes til 0 derefter vil loopet køre så længe i er mindre end længden på names til sammen? hver gang dette loop så kører vil i plusses med 1.
//hver gang loopet kører vil den beskrive hvilken string (i dette tilfælde navn) der er på hver plads i arrayen. Fordi vi så har sagt i skal plusses med 1 så vil den tage den næste værdi i arrayet hver gang den har kørt
//en omgang. indtil der ikke er flere nye værdier? eller indtil den når inden af arrayen?

//I opgave M12.1 havde vi et array af int. Hvad indeholder dette array?
//svar: strings. altså tekst. I dette tilfælde er teksten navne

//i for loopet bruger vi names.length. hvad betyder det?
//svar: det betyder at længdne af arrayen af variabler bruges i et for loop. ved overstående eksempel oplyses programmet at det skal køre et for loop hvor en variabel i deklereres til 0. Efter dette fortælles programmet
//at det skal køre så længe at i er mindre end names. length og skal efter loopet har kørt plusse i med 1 hver gang. I det loop vil hver gang loopet kører beskrive hvilken plads hvilket navn står. Så i dette tilfælde
//er .length længden af arrayet. dette måles så ud fra pladser frem for ud for tegn som det ville have gjort hvis det havde været en enkelt variabel som .elngth kommandoen blev brugt på.

//Prøv at ændre linjen names[2] = "Claus"; til names[2] = names[1]; Kør programmet. Hvad skete der?
//gjort til kommentar for at løse næste opgave.
/*
string[] names = new string[3];
names[0] = "Anton";
names[1] = "Benny";
names[2] = names[1];
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("På plads no. {0} er navnet {1}", i, names[i]);
}
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//svar: navnet på plads 3 altså på nmaes[2] blev sat = værdien ved names[1] altså names plads 2. Dermed endte der med at stå Benny ved plads 2 og 3 altså plads names[1] og names[2]

//Prøv at ændre linjen string[] names = new string[3]; til string[] names = new string[4]; Indsæt linjen names[3] = "Dirch"; oven over  linjen names[0] = "Anton"; Kør programmet! Hvad er ændret?
string[] names = new string[4];
names[3] = "Dirch";
names[0] = "Anton";
names[1] = "Benny";
names[2] = names[1];
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("På plads no. {0} er navnet {1}", i, names[i]);
}
Console.Write("Hit any key to exit");
Console.ReadKey();

//svar: det der er ændret er at vi har ændret arrayen til at indholde 4 pladser i stedet for 3. udover dette har vi angivet en ny værdi til d. 4. plads altså names[3]. Denne værdi er sat = "Dirch". Denne værdi skrives før
//de andre i arrayen. Dog fordi programmet spørges om at udskrive pladserne efterfulgt af navnene på pågældende plads i arrayen og at i sættes = 0 i loopet. vil den nye name værdi først blive set til sidst da det er den
//højeste værdi.