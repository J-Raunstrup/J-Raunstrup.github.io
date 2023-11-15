let humanScore = 0;
let computerScore = 0;
let currentRoundNumber = 1;

// Write your code below:
//own attempt.

//1.
const generateTarget = () => {
    return Math.floor(Math.random() * 10);
}

//2.
//working
//rewrite compareguesses to use getAbsoluteDistance
/*
const compareGuesses = (humanGuess, computerGuess, targetNumber) => {
    if ((humanGuess === computerGuess) && (computerGuess === humanGuess)) {
        if ((humanGuess === targetNumber) && (computerGuess === targetNumber)) {
            return true;
        }
        return true;
    } else if (humanGuess !== computerGuess) {
        if (humanGuess === targetNumber) {
            return true;
        } else if (computerGuess === targetNumber) {
            return false;
        } else if ((humanGuess > targetNumber) && (computerGuess > targetNumber)) {
            if ((humanGuess - targetNumber) <= (computerGuess - targetNumber)) {
                return true;
            }
        } else if ((humanGuess > targetNumber) && (computerGuess < targetNumber)) {
            if ((humanGuess - targetNumber) <= (targetNumber - computerGuess)) {
                return true;
            } 
        } else if ((humanGuess < targetNumber) && (computerGuess < targetNumber)) {
            if ((targetNumber - humanGuess) <= (targetNumber - computerGuess)) {
                return true;
            }
        } else if ((humanGuess < targetNumber) && (computerGuess > targetNumber)) {
            if ((targetNumber - humanGuess) <= (computerGuess - targetNumber)) {
                return true;
        }
    } else {
        return 'compare guesses error.';
    }
    }
}
*/

//6.
const getAbsoluteDistance = (number1, number2) => {
    let numberDistance;
    if (number1 === number2) {
        return numberDistance = number1 - number2;
    } else if (number1 < number2) {
        return numberDistance = number2 - number1;
    } else if (number1 > number2) {
        return numberDistance = number1 - number2;
    }
}

//working egen version.
const compareGuesses = (humanGuess, computerGuess, targetNumber) => {
    if ((humanGuess < 0) || (humanGuess > 9)) {
        return window.alert("Number out of range 0-9! The computer will win by default because of this.");
    }
    if ((getAbsoluteDistance(humanGuess, targetNumber)) === (getAbsoluteDistance(computerGuess, targetNumber))) {
        return true;
    } else if ((getAbsoluteDistance(humanGuess, targetNumber)) < (getAbsoluteDistance(computerGuess, targetNumber))) {
        return true;
    } else if ((getAbsoluteDistance(humanGuess, targetNumber)) > (getAbsoluteDistance(targetNumber, computerGuess))) {
        return false;
    } else {
    return 'compare guesses error.';
    }
}

//ny version der fylder mindre og er lettere at læse. gamle dog beholdt da det var egen løsning.
/*
const compareGuesses = (humanGuess, computerGuess, targetNumber) => {
    if ((humanGuess < 0) || (humanGuess > 9)) {
        return window.alert("Number out of range 0-9! The computer will win by default because of this.");
    }
    const humanDistance = getAbsoluteDistance(humanGuess, targetNumber);
    const computerDistance = getAbsoluteDistance(computerGuess, targetNumber);
    if (humanDistance === computerDistance) {
        return true;
    } else if (humanDistance > computerDistance) {
        return false;
    } else if (humanDistance < computerDistance) {
        return true;
    }
}
*/

//3.
const updateScore = (string) => {
    if (string === 'human') {
        humanScore++;
    } else if (string === 'computer') {
        computerScore++;
    }
}
//4.
const advanceRound = () => {
    currentRoundNumber++;
}

//5.
console.log(generateTarget());

console.log(compareGuesses(0, 5, 5));

console.log(updateScore('human'));

advanceRound();



//error med at computer vinder selvom user gæt er det samme som target number.

//fejlen var at der kun ville være retuneret true hvis differencen på humanGuess var mindre end på computerGuess. 
//Det vil sige at human guess = 3 og computer guess = 3 med target number = 3. ville give false da der ikke var sat en true kondition op for hvis computer gæt og bruger gæt var
//det samme. Altså virker det til det blev fikset. ved at fjerne else statementsne. Men endnu vigtigere. At tilføje et = tegn efter alle < operatører vde nestede if statements da
//der dermed ville blive retuneret en værdi hvis begge tal var = det samme. så ville brugeren skulle vinde.

//step 6.1 halvt. kunne dog gøres bedre. done efter løsning kigget. Det virkede fint uden. den anden metode er dog nemmere.
//step 6.2 done