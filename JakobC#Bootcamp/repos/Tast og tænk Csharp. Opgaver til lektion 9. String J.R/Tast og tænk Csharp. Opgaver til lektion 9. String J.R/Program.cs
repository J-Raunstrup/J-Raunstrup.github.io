// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//opgave M9.1 hele denne opgave gjort til kommentar for at løse næste opgave.
/*
string name = "Thorleif";
int length = name.Length;
Console.Write(name + " har en længde på " + length);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//Kør programmet. Hvad gør det?
//svar: det skriver navnet thorleif og gemmer det i en string variabel kaldet name. Derefter laver det en integer variabel der er = længden af name. Altså længden af Thorleif.
//Derefter skriver den navnet i dette tælfælde thorleif. Derefter skriver den en string der forklarer længden på navnet og derefter sættes længdens værdi efter. Til sidst
//skrvies der et console.write(); udsagn så brugeren ved hvad de skal gøre for at lukke programmet.

//Prøv at ændre linjen string name = "Thorleif"; til string name = "Ida"; Kør programmet igen. Hvad skete? Hvorfor?
/*
string name = "Ida";
int length = name.Length;
Console.Write(name + " har en længde på " + length);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//svar: Den gør det samme som før. Denne gang skriver den dog navnet ida og fortæller os længden på dette navn. Dette sker fordi vi har gemt vores tidligere værdier i variabler.
//Hvilket gør det nemmer at erstatte koden med nogle andre værdier uden at skulle skrive meget af koden om. Men vi i stedet kan få et nyt resultat udelukkende ved kun at
//ændre en linje.

//Prøv at ændre linjen til string name = "Ida Thorleifsson"; Hvad tror du sker, når du kører programmet nu?
/*
string name = "Ida Thorleifsson";
int length = name.Length;
Console.Write(name + " har en længde på " + length);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/
//svar: Det samme som før. Bare længden af det nye navn.

//Kør programmet! Skete der det, du forventede?
//svar: Der skete ikke helt det jeg forventede. Det samme som før med det nye navn. Dog tæller den længden med mellemrummet. Hvis vi gerne ville have længden uden
//mellemrum skulle vi bruge en anden kode.

//Forklar hvad name.Length gør i linjen int length = name.Length; 
//svar: name.Lenght tager længden af tegn i hele name variablen. Dette gælder også mellemrum og andre tegne. Også whitespace hvis der havde været det før eller efter variablen.
//derefter gemmes dette i int variablen lenght.



//opgave M9.2 hele denne opgave gjort til kommentar for at løse næste opgave.
/*
int index = 0;
string name = "Thorleif";
Console.WriteLine("Plads nr " + index + ": " + name[index]);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//Kør programmet. Hvad gør det?
//svar: programmet tjekker efter hvad et specifict tegn er for en given index værdi. Dermed hvis vi er nysgerrige på hvad hvert tegn er i string variablen. Så kan vi taste et
//tal som index og derefter se hvad dette tegn er og hvilken plads det har.

//Prøv at ændre linjen int index = 0; til int index = 3; Hvad tror du der sker når du kører programmet igen?
/*
int index = 3;
string name = "Thorleif";
Console.WriteLine("Plads nr " + index + ": " + name[index]);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//svar: jeg gætter på det vil tage det 3. index. altså r da det første index er = 0. Altså er index 3 = 4. tegn. dermed r. Så vil den nok sige plads nr 3: r

//Kør programmet. Hvad skete der? Var det hvad, du forventede?
//svar: ja det var umiddelbart hvad jeg forventede.

//Hvilken position(index nummer) har det sidste bogstav i name?
//svar: name[name.Length - 1]; eller 7.

//Prøv at ændre linjen til int index = name.Length - 1; Kør programmet. Hvad skete? Hvorfor?
/*
int index = name.Length - 1;
string name = "Thorleif";
Console.WriteLine("Plads nr " + index + ": " + name[index]);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/
//det giver error da index skal skrives efter name før name variablen kan bruges ved index da den ikke er erklæret inden brugen af index som bruger name.
//Dog kan de byttes rundt på så programmet kan bruge name variablen.
/*
string name = "Thorleif";
int index = name.Length - 1;
Console.WriteLine("Plads nr " + index + ": " + name[index]);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/
// dette giver outputtet: Plads nr 7: f



//opgave M9.2 indexOf hele denne opgave gjort til kommentar for at løse næste opgave.
/*
int index;
string name = "Ida Thorleifsson";
string search = "Thorleif";
index = name.IndexOf(search);
Console.WriteLine("Fandt " + search + " på plads nr " + index);
Console.WriteLine("Hit any key to exit");
Console.ReadKey();
*/

//Kør programmet.Hvad gør det?
//svar: Den søger efter en string værdi angivet i search. Denne værdi prøver den at finde i string variablen name. Derefter skriver programmet hvad den fandt og hvor
//i name variablen.

//Forklar hvad search og index gør i den linje der skriver på skærmen.
//I console.WriteLine(); linjen bruges 2 variabler. Search og Index. Disse 2 combineres med flere tegn i en string til at give os en linje med tekst og variabel værdierne indsat.
//Search refererer til string variablen search
//hvor vi har sagt den skal søge Efter Thorleif. Index variablen blev sat til indexet af name hvor vores search string er sted. dermed vil index give os et tal der er
//indexet af starten af search i string variablen name.

//Prøv at ændre linjen string search = "Thorleif"; til string search = "ss"; Hvad tror du sker når du kører programmet igen?
/*
int index;
string name = "Ida Thorleifsson";
string search = "ss";
index = name.IndexOf(search);
Console.WriteLine("Fandt " + search + " på plads nr " + index);
Console.WriteLine("Hit any key to exit");
Console.ReadKey();
*/
//svar: jeg tror dette vil give outputtet: Fandt ss på plads nr 12.
//da vi erstatter search fra thorleifsson med ss. Dermed skal programmet søge efter ss i stedet. Da ss så starter på index 12. Antager jeg dette vil være outputtet.

//Hvad skete? Var det, hvad du forventede?
//Det var mere eller mindre det der blev forventet.

//Forklar hvad name.IndexOf(search); gør.
//svar: name.IndexOf(search). Bruger værdien search og bruger dette til at tage indexet af dette i variablen name.



//opgave M9.3  indexOf hele denne opgave gjort til kommentar for at løse næste opgave.
/*
int index;
string name = "Thorleif Grimsson";
index = name.IndexOf("Grim");
string lastname = name.Substring(index);
Console.WriteLine("Efternavnet er " + lastname);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//Kør programmet. Hvad gør det?
//svar: jeg er ikke sikker. jeg antager dog at dette program har en int index variabel og en navn string variabel. Derefter sættes index = indexet af name hvor teksten
//"Grim" indgår. Derefter så laves en string variabel ved navn lastname der sættes = substringen af name hvor index er sandt. altså hvor index er Grim
//vil den tage indtil slutningen af stringen. Derefter vil den fortælle brugeren hvordan programmet lukkes.

//Skriv programmet om:
/*
int index;
string name = "Thorleif Grimsson";
index = name.IndexOf(" ");
string lastname = name.Substring(index, 1);
Console.WriteLine("Efternavnet er " + lastname);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//Hvad tror du sker når du kører programmet igen?
//svar: den gør det samme som det forgående program. Den er dog mere omskiftelig hvis efternavnet skulle erstattes med noget andet da andre efternavne ikke nødvendigvis
//indeholder navnet "grim"

//Kør programmet! Hvad skete? Hvorfor?
//svar: Det jeg troede der ville ske var ikke rigtigt. Der endte med at outputte tom tekst. Da programmet blev oplyst det skulle outputte lastname ligesom før.
//dog denne gang er lastname sat = substringen af name fra index som er sat = " " så derefra hen til et tegn mere til højre. 

//Forklar hvad Substring gør:
//svar: subtring tager tekst fra en string f.eks. og kopirer dette fra en string. dette kan så derefter specificeres med 1: hvor den skal starte og 2: hvor langt hen mod højre
//at substringen skal tage tegn med. Derefter kan dette bruges til at kopiere ønskede værdier eller tegn fra en tekst. Eller f.eks. hvis de skulle bruges i andre variabler.

//spørgsmål: er det at fjerne det samme som at trække ud? det antager jeg ikke det er. vil bare være sikker.
//svar: det er det ikke. at trække ud er ligesom at kopiere noget.

//opgave M9.4
/*
int index = 0;
string middleName;
string name = "Ida Sofie Thorleifsdottir";
index = name.IndexOf("Sofie");
middleName = name.Substring(index, "Sofie".Length);
Console.WriteLine("Mellemnavnet er " + middleName);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/

//Kør programmet. Hvad gør det?
//svar: programmet laver 3 variabler. index, middleName og name. Name sættes = et navn. index sættes = indexet af navnet hvor teksten "Sofie" er.
//middleName sættes = substringen af name hvor index starter indtil "Sofie.Length's slutning. Dermed vil det skrive til sidst i Console.WriteLine() udsagnet.
//"Mellemnavnet er Sofie". Derefter siger programmet hvad man skal gøre for at lukke det.

//Prøv at ændre  linjen middleName = name.Substring(index, "Sofie".Length); til middleName = name.Substring(index, 5); Hvad tror du, der sker nu?
/*
int index = 0;
string middleName;
string name = "Ida Sofie Thorleifsdottir";
index = name.IndexOf("Sofie");
middleName = name.Substring(index, 5);
Console.WriteLine("Mellemnavnet er " + middleName);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/
//svar: jeg tror den vil outputt det samme som før. Dog denne gang vil den kopiere mellemrummet med. Da vi siger til programmet den skal starte samme sted.
//Dog denne gang stoppe kopieringen efter 5 tegn mod højre fra starten er blevet markeret til kopiering.

//Kør programet. Skete der noget nyt? Hvorfor/hvorfor ikke?
//svar: der skete ikke noget nyt da den starter på Sofie og ikke lige før. Derudover stopper den efter den har en længde på 5 tegn inkluderende indexets start tegn.
//Jeg troede den startede på S'et i sofie. Det gør dne også. Det 2. parametre til substring angiver længden på det der skal kopieres med indexets start tegn inkluderet.

//Prøv at ændre linjen til: middleName = name.Substring(0, 3); Hvad tror du, der sker der nu?
/*
int index = 0;
string middleName;
string name = "Ida Sofie Thorleifsdottir";
index = name.IndexOf("Sofie");
middleName = name.Substring(0, 3);
Console.WriteLine("Mellemnavnet er " + middleName);
Console.Write("Hit any key to exit");
Console.ReadKey();
*/
//svar: jeg tror programmet vil outputte: Mellemnavnet er Ida. Dette virker dog ulogisk og forkert. Jeg antager dog dette da vi angiver den skal starte kopieringen ved 0
// og slutte afmærkningen n¨år længden er 3 tegn lang. Dette virker dog forkert da dette ikke er mellemnavnet.

//Kør programmet. Hvad skete? Hvorfor?
//svar: dette var rigtigt. Jeg kom dog tl at taste 5 i stedet for 3. Dette var en sjuske fejl.



//opgave M9.5
//Start et nyt C# projekt og indtast den fremhævede kode (den med grå baggrund) i Main’s scope.
/*
string name = "Thorleif Hermann Hagbard";
string upper = name.ToUpper();
string lower = name.ToLower();
Console.WriteLine("Name: " + name);
Console.WriteLine("Upper: " + upper);
Console.WriteLine("Lower " + lower);
Console.WriteLine("Hit any key to exit");
Console.ReadKey();
*/
//Kør programmet.Hvad gør det?
//svar: programmet laver 3 variabler. name, upper og lower. Alle 3 variabler er af typen string. name har en string værdi med prædefinerede store og små bogstaver.
//upper har en string værdi med en egenskab ToUpper()
//der gør at alle tegnene i name kaldet via upper bliver til store bogstaver. Lower gør det modsatte af upper og tager alle tegnene til små bogstaver i stedet for store.
//Derefter skrives alle 3 variabler ud til konsollen med nogle yderligere string værdier hver især. Til sidst siger programmet hvordna brugeren kan afslutte programmet.

//Prøv at ændre linjen string name="Thorleif Hermann Hagbard" til f eks string name = "beNtE lArSeN PetERseN". Kør programmet igen.Hvad gør ToLower og ToUpper?
/*
string name = "beNtE lArSeN PetERseN";
string upper = name.ToUpper();
string lower = name.ToLower();
Console.WriteLine("Name: " + name);
Console.WriteLine("Upper: " + upper);
Console.WriteLine("Lower " + lower);
Console.WriteLine("Hit any key to exit");
Console.ReadKey();
*/

//svar: programmet gør det samme som før. Denne gang bare med et andet navn. Dog denne gang kan vi bedre se hvad programmet gør da der er flere store og små bogstaver
//i stringen name. Altså to upper gør alle tegnene i name store og to lower gør alle tegnene i name til små bogstaver.

//Skriv programmet om:

string name = "Thorleif Hermann Hagbard";
Console.WriteLine("name: " + name);
Console.WriteLine("upper: " + name.ToUpper());
Console.WriteLine("lower: " + name.ToLower());
Console.Write("Hit any key to exit");
Console.ReadKey();

//Kør programmet. Er der forskel? Hvorfor/hvorfor ikke?
//svar: i princippet burde der ikke være forskel da det er stadig de samme værdier der bruges ved Console.WriteLine() statementsne. Den eneste forskel er
//at i stedet for at referrer til en variabel der er blevet angivet en værdi tidligere. Så skrives værdien i stedet direkte ind ved Console.WriteLine() statementsne.
//med ToUpper() og ToLower() egenskaberne.