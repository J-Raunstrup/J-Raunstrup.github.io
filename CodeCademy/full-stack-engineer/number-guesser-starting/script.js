let humanScore = 0;
let computerScore = 0;
let currentRoundNumber = 1;

// Write your code below:

function generateTarget() {
    return Math.floor(Math.random() * 10);
}

function getAbsoluteDistance(number1, number2) {
    distance = Math.abs(number1 - number2)
    return distance;
}

function compareGuesses(humanGuess, computerGuess, targetGuess) {
    humanDistance = getAbsoluteDistance(humanGuess, targetGuess);
    computerDistance = getAbsoluteDistance(computerGuess, targetGuess);
    if ((humanGuess >= 0) && (humanGuess <= 10)) {
        if (humanDistance > computerDistance) {
            return false;
        }
        else if (humanDistance < computerDistance) {
            return true;
        }
        else if (humanDistance === computerDistance) {
            return true;
        }
    }
    else {
        alert('Number out of range 0-10!');
        return false;
    }
}

const updateScore = winner => {
    if (winner === 'human') {
        return humanScore++;
    }
    else if (winner === 'computer') {
        return computerScore++;
    }
}

function advanceRound() {
    return currentRoundNumber++;
}




//6. part 1 done.
//6. part 2


/*
function generateTarget() {
    return Math.floor(Math.random() * 10);
}

function compareGuesses(humanGuess, computerGuess, targetGuess) {
    if ((Math.abs(humanGuess - targetGuess)) > (Math.abs(computerGuess - targetGuess))) {
        return false;
    }
    else if ((Math.abs(humanGuess - targetGuess)) < (Math.abs(computerGuess - targetGuess))) {
        return true;
    }
    else if ((Math.abs(humanGuess - targetGuess)) === (Math.abs(computerGuess - targetGuess))) {
        return true;
    }
}

const updateScore = winner => {
    if (winner === 'human') {
        return humanScore++;
    }
    else if (winner === 'computer') {
        return computerScore++;
    }
}

function advanceRound() {
    return currentRoundNumber++;
}


console.log(generateTarget());
console.log(compareGuesses(2, 4, 3));
console.log(updateScore('human'));
console.log(advanceRound());
*/