// Returns a random DNA base
const returnRandBase = () => {
  const dnaBases = ['A', 'T', 'C', 'G'];
  return dnaBases[Math.floor(Math.random() * 4)];
};

// Returns a random single stand of DNA containing 15 bases
const mockUpStrand = () => {
  const newStrand = [];
  for (let i = 0; i < 15; i++) {
    newStrand.push(returnRandBase());
  }
  return newStrand;
};

//3.
const pAequorFactory = (number, array) => {
  return {
      specimenNum: number,
      dna: array,
      //4.
      mutate() {
        const randIndex = Math.floor(Math.random() * this.dna.length)
        let randDnaBase = returnRandBase();
        while (this.dna[randIndex] === randDnaBase) {
          randDnaBase = returnRandBase();
        }
        this.dna[randIndex] = randDnaBase
        return this.dna
      },
      //5. solution checked. tried to do the solution in ones own way. but very similiar.
      compareDNA(aNewObjectToCompare) {
        let count = 0;
        for (let i = 0; i < this.dna.length; i++) {
          if (this.dna[i] === aNewObjectToCompare.dna[i]) {
            count++;
          }
          //else statement not necessary. its a test to make sure of if check.
          else {
            //console.log("no match");
          }
        }
        const dnaBasesInCommon = (count / this.dna.length) * 100;
        const dnaBasesInCommonRounded = dnaBasesInCommon.toFixed(2)
        //code line below removed to solve 9.2
        //console.log(`specimen #${this.specimenNum} and specimen #${aNewObjectToCompare.specimenNum} have ${dnaBasesInCommonRounded}% DNA in common.`);
        //1 line below added by oneself to solve 9.2
        return dnaBasesInCommonRounded
      },
      //6.
      willLikelySurvive() {
        let numberOfCBases = 0;
        let numberOfGBases = 0;
        for (let i = 0; i < this.dna.length; i++) {
          if (this.dna[i] === "C") {
            numberOfCBases++;
          } else if (this.dna[i] === "G") {
            numberOfGBases++;
          } else {
            //console.log("No match.");
          }
        }
        const numberOfSurvivalBases = numberOfCBases + numberOfGBases;
        const chanceOfSurvival = (numberOfSurvivalBases / this.dna.length) * 100;
        //console.log("Chance of survival: " + chanceOfSurvival);
        if (chanceOfSurvival >= 60) {
          return true;
        } else {
          return false;
        }
      }, 
      //9.
      complementStrand(array) {
        let complementaryDnaStrand = [];
        for (let i = 0; i < array.length; i++) {
          if (array[i] === "A") {
            complementaryDnaStrand[i] = "T"
          } else if (array[i] === "T") {
            complementaryDnaStrand[i] = "A"
          } else if (array[i] === "C") {
            complementaryDnaStrand[i] = "G";
          } else if (array[i] === "G") {
            complementaryDnaStrand[i] = "C";
          }
        }
        //console.log(array);
        //console.log(complementaryDnaStrand);
        return complementaryDnaStrand;
      }
  }
}

let testArray = ['A', 'T', 'C', 'G', 'A', 'T', 'C', 'G', 'A', 'T', 'C', 'G', 'A', 'T', 'C']
let testArray2 = ['A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A']

let testObjToCompareDNA = pAequorFactory(2, testArray2)


//console.log(pAequorFactory(1, testArray));

//9. test
pAequorFactory(1, testArray).complementStrand(testArray);

//console.log(pAequorFactory(1, testArray).mutate());

//5.
//pAequorFactory(1, testArray).compareDNA(testObjToCompareDNA);

//6.
//console.log(pAequorFactory(1, testArray).willLikelySurvive());

//7.
//create 30 examples of object
let testArrayWith30Objects = [];
for (let i = 0; i < 30; i++) {
  testArrayWith30Objects[i] = pAequorFactory(i, mockUpStrand());
  //console.log(testArrayWith30Objects[i]);
  //testArrayWith30Objects[i].willLikelySurvive()
  if (testArrayWith30Objects[i].willLikelySurvive() === true) {
    //console.log("Result: true");
    //console.log(i);
  } else {
    while (testArrayWith30Objects[i].willLikelySurvive() === false) {
      //console.log("Result: false");
      //console.log(testArrayWith30Objects[i].willLikelySurvive());
      testArrayWith30Objects[i].dna = mockUpStrand();
    }
  }
}

//console.log(testArrayWith30Objects);

//9.2
//console.log(testArrayWith30Objects[0].compareDNA(testArrayWith30Objects[1]));

const findMostSimiliarDnaStrands = (array) => {
  let highestDnaMatch = 0;
let dnaMatch = 0;
for (let i = 0; i < array.length; i++) {
  for (let j = 0; j < array.length; j++) {
    if (i === j) {
      //array[i].compareDNA(array[j]);
    } else if (i !== j) {
      if (dnaMatch > highestDnaMatch) {
        highestDnaMatch = dnaMatch
      } else if (dnaMatch < highestDnaMatch) {
        highestDnaMatch = highestDnaMatch
      }
    }
    //console.log(`I value: ${i} J value: ${j}`);
    dnaMatch = array[i].compareDNA(array[j])
    //console.log(dnaMatch);
    //console.log(testArrayWith30Objects[i].compareDNA(testArrayWith30Objects[j]));
  }
}

console.log(`Highest Dna match: ${highestDnaMatch}`);

for (let i = 0; i < array.length; i++) {
  for (let j = 0; j < array.length; j++) {
    if (i === j) {

    } else if (i !== j) {
      if (dnaMatch === highestDnaMatch) {
        console.log(`I value ${i} J Value: ${j} dna in common: ${dnaMatch}`);
      }
    }
    dnaMatch = array[i].compareDNA(array[j])
  }
}
}
findMostSimiliarDnaStrands(testArrayWith30Objects)


//pAequorFactory(0, testArrayWith30Objects[0]).compareDNA(testArrayWith30Objects[1]);

//pAequorFactory();

//link to img used for 8.: 
//https://www.genome.gov/sites/default/files/media/images/tg/Base-pair_dyn.jpg


//9 mangler et check der kunn esammneligne hvilken 2 dna'er der er mest relateret. uklart om dette skulle være deres match der skulle passe bedst. 
//eller om man bare skulle tjekke hvilket der var mest identisk.

//der burde være en metode der kunne sammenligne dna. måske kunne man tage resultatet tallet fra dette og finde det største sammenlignings tal derefter.