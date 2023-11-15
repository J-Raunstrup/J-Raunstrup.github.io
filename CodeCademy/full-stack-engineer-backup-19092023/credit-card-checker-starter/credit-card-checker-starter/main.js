// All valid credit card numbers
//starting code given.
const valid1 = [4, 5, 3, 9, 6, 7, 7, 9, 0, 8, 0, 1, 6, 8, 0, 8]
const valid2 = [5, 5, 3, 5, 7, 6, 6, 7, 6, 8, 7, 5, 1, 4, 3, 9]
const valid3 = [3, 7, 1, 6, 1, 2, 0, 1, 9, 9, 8, 5, 2, 3, 6]
const valid4 = [6, 0, 1, 1, 1, 4, 4, 3, 4, 0, 6, 8, 2, 9, 0, 5]
const valid5 = [4, 5, 3, 9, 4, 0, 4, 9, 6, 7, 8, 6, 9, 6, 6, 6]
//0*0. 6*2=12-9=3. 0*0=0. 0*0=0. 7*2 = 14-9=5. 6*2=12-9=3. 3*2=6. 4*2=8.
//0+3+0+0+5+3+6+8=25
//8+8+1+8+9+7+9+5=55
//25+55=80.

// All invalid credit card numbers
const invalid1 = [4, 5, 3, 2, 7, 7, 8, 7, 7, 1, 0, 9, 1, 7, 9, 5]
const invalid2 = [5, 7, 9, 5, 5, 9, 3, 3, 9, 2, 1, 3, 4, 6, 4, 3]
const invalid3 = [3, 7, 5, 7, 9, 6, 0, 8, 4, 4, 5, 9, 9, 1, 4]
const invalid4 = [6, 0, 1, 1, 1, 2, 7, 9, 6, 1, 7, 7, 7, 9, 3, 5]
const invalid5 = [5, 3, 8, 2, 0, 1, 9, 7, 7, 2, 8, 8, 3, 8, 5, 4]

// Can be either valid or invalid
const mystery1 = [3, 4, 4, 8, 0, 1, 9, 6, 8, 3, 0, 5, 4, 1, 4]
const mystery2 = [5, 4, 6, 6, 1, 0, 0, 8, 6, 1, 6, 2, 0, 2, 3, 9]
const mystery3 = [6, 0, 1, 1, 3, 7, 7, 0, 2, 0, 9, 6, 2, 6, 5, 6, 2, 0, 3]
const mystery4 = [4, 9, 2, 9, 8, 7, 7, 1, 6, 9, 2, 1, 7, 0, 9, 3]
const mystery5 = [4, 9, 1, 3, 5, 4, 0, 4, 6, 3, 0, 7, 2, 5, 2, 3]

// An array of all the arrays above
const batch = [valid1, valid2, valid3, valid4, valid5, invalid1, invalid2, invalid3, invalid4, invalid5, mystery1, mystery2, mystery3, mystery4, mystery5]

//7.
let testArray = [2, 7, 2, 0, 9, 9, 3, 1, 8, 8, 6, 1, 8, 4, 4, 2];

let cardFromSomewhereElse = "5204133016995732";




// Add your functions below:
//made locally. copied to code cademy as a little backup.
//7.
const stringToIntArrayConverter = (string) => {
    var b = string.split('').map(function(item) {
        return parseInt(item, 10);
    });
    return b;
}



//1.
//2.
//3. lav validateCreed function. done.
//checker om et kredit kort har gyldige eller falske tal udfra en sum som er udregnet med en matematisk metode. 0 hvis kortet er gyldigt. alle andre tal hvis ikke gyldigt. 
//dette evalueres til true eller false og retuneres.

const validateCreed = (array) => {
    //mangler at double hver anden array.
    //uklar om der er en fejl ved nogle af loopsne eller om det er ved if else statementsne. måske er det fordi doubled number ikke bliver sendt tilbage efter det er minusset med 9.
    // dog ikke helt sikker
    let doubledNumber = 0;
    let sumOfDoubledNumbers = 0;
    let moduloOfSummedNumbers = 0;
    let sumOfNormalNumbers = 0;
    let totalSum = 0;
    //below should be working.
    for (let i = array.length-1; i > -1; i--) {
        //console.log("im the normal array: " + array[i]);
    }
    //below should be working.
    for (let i = array.length-2; i > -1; i = i-2) {
        //console.log("i skipped 1 array number so now im on " + array[i]);
        doubledNumber = array[i] * 2;
        if (doubledNumber > 9) {
            doubledNumber = doubledNumber - 9;
            //console.log(`I used to be ${array[i]}, but now i have been doubled and i was above 9 after doubling so i got minused by 9. So now im ${doubledNumber}`);
        } else {
            //console.log(`I used to be ${array[i]}, but now i have been doubled. So now im ${doubledNumber}`);
        }
        sumOfDoubledNumbers = sumOfDoubledNumbers + doubledNumber;
        //console.log("Sum of doubled numbers: " + sumOfDoubledNumbers);
    }
    for (let i = array.length-1; i > -1; i = i-2) {
        sumOfNormalNumbers = sumOfNormalNumbers + array[i];
        //console.log("i skipped 1 array number so now im on " + array[i]);
        //console.log("Sum of normal numbers: " + sumOfNormalNumbers);
    }
    totalSum = sumOfNormalNumbers + sumOfDoubledNumbers;
    //console.log("Total sum: " + totalSum);
    moduloOfSummedNumbers = totalSum % 10;
    //console.log("Modulo of sum of doubled numbers: " + moduloOfSummedNumbers);
    if (moduloOfSummedNumbers === 0) {
        return true;
    } else {
        return false;
    }
}

//console.log(validateCreed(invalid1));
//7. make a function that makes invalid valid. This does convert invalid to valid. as in the sense that it evaluates to true. However since it has the value true as its return value.
//that means that it cant see what company the card is from since the card numbers dont get changed. I dont know if there is any other way to do this without changing the entire
//number. however then the issue is what numbers should be changed since it cant be the first one if you want to know the company. Im assuming a total number cant evaluate to zero.
//if that is the case i would assume it would be possible however i dont think i know how.
let makeMeValid = invalid5;

const convertInvalidCardsToValid = (string) => {
    if (validateCreed(string) === false) {
        let newValue = validateCreed(string);
        newValue = true;
        return newValue;
    }
}



let invalidToValid = convertInvalidCardsToValid(makeMeValid);
//console.log(invalidToValid);


//4. hint used.
//function
const findInvalidCards = (array) => {
    let newInvalidCardsArray = [];
    for (let i = 0; i < array.length; i++) {
        //console.log(array[i]);
        //console.log(validateCreed(array[i]));
        if (validateCreed(array[i]) === false) {
            newInvalidCardsArray.push(array[i]);
        } else {
            newInvalidCardsArray = newInvalidCardsArray;
        }
    }
    return newInvalidCardsArray
}

//prints invalid card arrays.
//console.log(findInvalidCards(batch));



//function.
const idInvalidCardCompanies = (array) => {
    let arrayOfCompanies = [];
    for (let i = 0; i < array.length; i++) {
        //console.log(array[i]);
        if (array[i][0] === 3) {
            arrayOfCompanies.push('Amex')
        } else if (array[i][0] === 4) {
            arrayOfCompanies.push('Visa')
        } else if (array[i][0] === 5) {
            arrayOfCompanies.push('Mastercard')
        } else if (array[i][0] === 6) {
            arrayOfCompanies.push('Discover')
        } else {
            arrayOfCompanies.push('Company not found')
        }
    }

    let aNoDuplicates = [];

    const aCompanyList = ['Amex', 'Visa', 'Mastercard', 'Discover', 'Company not found'];
    
    //shows list of companies
    //console.log('List of companies: ' + aCompanyList);

    //console.log(arrayOfCompanies);

    for (let i = 0; i < arrayOfCompanies.length; i++) {
        if (aNoDuplicates.indexOf(arrayOfCompanies[i]) === -1) {
            aNoDuplicates.push(arrayOfCompanies[i]);
        } else {
            aNoDuplicates = aNoDuplicates;
        }
    }

    return aNoDuplicates;
}



//7.

let stringConvertedArray = stringToIntArrayConverter(cardFromSomewhereElse);

//print to console.
//console.log("These companies have credit cards with invalid numbers: ");
console.log(idInvalidCardCompanies(batch));

console.log(idInvalidCardCompanies([invalid1]));

console.log(idInvalidCardCompanies([testArray]));

console.log(idInvalidCardCompanies([stringConvertedArray]));

console.log(idInvalidCardCompanies([invalidToValid]));



//old code and why it didnt work:
//4.
//denne funktion skulle kunne tjekke en nested array igennem og retunere en ny array hvor det kun er kredit kort i en array der har falske tal. 
//altså retunere en ny array der har en sum der kun evalueres til andet en 0. altså false. 
//Dette kunne gøres bl.a. via et loop. hvor derefter hver element i en nested array tjekkes igennem med validatecreed funktionen.
//hvis validatecreed med en parameter af arrayen på plads i retunerer andet end 0. så burde det gemmes i en array via push commanden. da det dermed er falske kort.

//nok pga det skulle være et loop der checkede hver plads i en array og dermed ikke måtte bruges på normale arrays og kun nestede arrays.

//should print correct true or false values. though doesnt push to end of array. it just pushes all of them instead of none.
//der var 2 fejle ved denne kode. Den første var en scope fejl. Da return værdien kører hver gang loopet har kørt. Dog da en funktion ikke kan retunere flere ting så stopper loopet
//inde i funktionen og dermed vil koden stoppe før tid. Dermed vil den skrive.

//den anden var en referenceerror. Da det blev skrevet .push(array). Så bliver hele arrayen der loopes igennem skrevet hvis indexet på array er = false. Da den første element i
//arrayet er true vil den dermed ikke pushe noget til den nye array og dermed når arrayen så retuneres så er den tom da loopet stoppede inden det kunne kigge de andre indexer
//igennem grundet som sagt at når en return værdi er i en funktion. vil funktionen oftes ikke kigge på resten af koden og stoppe derefter. Altså

//der var en referenceerror ved push commanden. Det skulle være indexet af en array der skulle pushes og ikke en hel array der skulle pushes hver gang array med plads i var = false.
//derudover en scope error der ville gøre koden ikke ville loope igennem hele arrayet pga en return command skrevet i et loop. Den skulle have været ude af loopet.
/*
const findInvalidCards = (array) => {
    //console.log("test1");
    let falseCardsNumbersArray = [];
    for (let i = 0; i <array.length; i++) {
        validateCreed(array[i]);
            //console.log("test2");
    if (validateCreed(array[i]) === false) {
        console.log("if false statement: value of validateCreed array i: " + validateCreed(array[i]));
        console.log("test3");
        console.log("This is my value" + validateCreed(array));
        falseCardsNumbersArray.push(array[i]);
    } else if (validateCreed(array[i]) === true) {
        for (let j = 0; j < array.length; j++) {
            console.log("else if true statement: value of validateCreed array i: " + validateCreed(array[j]));
            console.log("test4");
            console.log("This is my whole arrays value: " + validateCreed(array));
        }
    } else {
        console.log("else statement: error");
    }
    }
    return falseCardsNumbersArray;
}
console.log(findInvalidCards(batch));
*/



//thoughts and why one assignment didnt work.
//5.
//doesnt work for bigger arrays nested. seems at first glance though that it works.

/*
First Digit	Company
3	        Amex (American Express)
4	        Visa
5	        Mastercard
6	        Discover
*/

//first part seems to work. companies get written depending on the first number in the array. 
//however its printing every company twice. it should only print each company once.

//im assuming this can be solved with a loop within a loop. 
//The first loop should check if the targetArray array contains one of the company names from the list of Companies array. if it does it shouldnt assign a new value and increase the
//counter by 1. that means that the search through the get array moves one step ahead 
//

//tænkte man måske kunne bruge nestede loops eller splice og map. Dog blev hintet checket og det blev forslået at bruge indexOf. Det kunne nok løses med andre men dette
// løste problemet.
//hint brugt.