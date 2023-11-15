//1.
let _ = {
    //3.
    //own version working.
    /*
    clamp(number, minNum, upperNum) {
        if (number > upperNum) {
            number = upperNum;
        } else if (number < minNum) {
            number = minNum;
        } else if ((number < upperNum) && (number > minNum)) {
            number = number;
        }
        return number;
    }
    */
   //own attempt. think it could be working. not working. though it was worth a try,
    /*
   clamp(number, minNumber, upperNum) {
    let test1 = Math.max(number, minNumber);
    let test2 = Math.min(test1, upperNum);
    return `Test 1: ${test1}, Test 2: ${test2}`;
   }
   */
  clamp(number, lower, upper) {
    let lowerClampedValue = Math.max(number, lower);
    let clampedValue = Math.min(lowerClampedValue, upper);
    return clampedValue;
  },
  //4.
  /*
  inRange(number, [start=0], end) {
    if ((number > [start=0]) && (number < end)) {
        return true;
    } else {
        return false;
    }
  }
  */
  //7. own attempt. seems to be working.
  /*
  inRange(number, start, end) {
    let testVariable1 = 0;
    let testVariable2 = 0;

    if (end === undefined) {
        end = start;
        start = 0;
    } else if (start > end) {
        testVariable1 = start;
        testVariable2 = end;
        start = testVariable2;
        end = testVariable1;
    }

    if ((number < end) && (number >= start)) {
        return true;
    } else if (number < start) {
        return false;
    } else if (number >= end) {
        return false;
    }
  }
  */
  //code cademy version.
  /*
  inRange(number, start, end) {
    if (end === undefined) {
        end = start;
        start = 0;
    }
    if (start > end) {
        const temp = end;
        end = start;
        start = temp;
    }
    let isInRange = 0;
    if ((start <= number) && (end > number)) {
        isInRange = true;
        return isInRange
    } else {
        isInRange = false;
        return isInRange;
    }
  }
  */
 //upodated own version. think i prefer this because of code readability. however i wanted to correct the 2. if else check. so that it was an if statement instead of an else if.
 //so that i would make sure it would check both for if end was undefined and if start was bigger than end. rather than only one of them.
  inRange(number, start, end) {
    let testVariable1 = 0;
    let testVariable2 = 0;

    if (end === undefined) {
        end = start;
        start = 0;
    } 
    
    if (start > end) {
        testVariable1 = start;
        testVariable2 = end;
        start = testVariable2;
        end = testVariable1;
    }

    if ((number < end) && (number >= start)) {
        return true;
    } else if (number < start) {
        return false;
    } else if (number >= end) {
        return false;
    }
  },
  //11. own attempt. think its working.
  
  words(string) {
    const stringArray = string.split(" ");
    return stringArray;
  },
  
 //code cademy version.
 /*
  words(string) {
    const words = string.split(' ');
    return words;
  }
  */
 //15. wasent realy sure how to solve it.
    /*
    pad(string, length) {
    let char = " ";
    for (let i = string.length; i < length; i++) {
        
    }
    return string;
  }
  */
 //own attempt. didnt work at the start though made a lttle adjustement with a variable minussing the wrong variable. seems to pass the test now. i think the codecademy version
 //is less readable however i think its more flexible and more organized so i prefer take the codecademy version in this case. Also it takes up less lines so i think
 // it might run faster. though not sure.
 /*
    pad(string, length) {
        if (length > string.length) {
            let paddingStart = Math.floor((length - string.length) / 2);
            let paddingEnd = length - (string.length + paddingStart);
            for (let i = 0; i < paddingStart; i++) {
                string = " " + string;
            }
            for (let i = 0; i < paddingEnd; i++) {
                string = string + " ";
            }
            return string;
        } else {
            return string;
        }
    }
*/
//codecademy version.

    pad(string, length) {
        if (length <= string.length) {
            return string;
        }
        startPaddingLength = Math.floor((length - string.length ) / 2);
        endPaddingLength = length - string.length - startPaddingLength;
        let paddedString = `${' '.repeat(startPaddingLength)}${string}${' '.repeat(endPaddingLength)}`
        return paddedString;
    },
    //19. own attempt. preffered since it takes up less amounts of code and the value at the end wont have a name either way. i think it gets over complicated with more lines and
    //variables in this case. that might just be though. not sure.
    
    has(object, key) {
        if (object[key] !== undefined) {
            return true;
        } else {
            return false;
        }
    },
    //codecademy version.l
   /*
    has(object, key) {
        let hasValue = 0;
        if (object[key] !== undefined) {
            hasValue = true;
        } else {
            hasValue = false;
        }
        return hasValue;
    }
    */
   //23. i would assume that a loop of some sort is neccessary. i think i would be able to do this on an array. however i dont think im sure about how to reassign a keys name.
   // im not sure how.
   //didnt work.
   /*
    invert(object) {
        let testObject = {};
        let count = 0;
        for (const property in object) {
            console.log(`${property}: ${object[property]}`);
            for (let i = object.length; i >= 0; i--) {
                testObject[count] = object[i];
                count++;
            }
        }
        return testObject;
    }
    */
    //25. own attempt. not working.
    /*
    invert(object) {
        let invertedObject = {};
        for (const originalValue in object) {
            invertedObject[originalValue] = key;
        }
        return invertedObject;
    }
    */
   //hint viewed. error was multiple things. first of all key wasnt defined in own attmept. also originalvalue was defined but in a confusing context and assigned the
   //key instead of being assigned the keys value. That way i think it would only have been a value and no keys. in the new attempt key is defined in the loop declaration
   //also original value gets assigned the object keys value instead of being assigned as the objects key. also the ivnertedobject with an index of original value will get
   //assigned to key. how this reverses the result i am not entirely sure though. sadly.
   //26. i think it works. though i dont think i understand why sadly.
   //i dont understand how objects keys and values get reassigned automatically. i dont know how to reasisng an objects key to be something else 
   //and an objects value to be something else in this way.
   invert(object) {
    let reversedObject = {};
    for (let key in object) {
        const originalValue = object[key];
        reversedObject[originalValue] = key;
    }
    return reversedObject;
   },
   //27. own attmept
   /*
   findkey(object, fPerIteration) {
    for (let key in object) {
        if (fPerIteration(key) === true) {
            return object[key];
        } else if (fPerIteration(key) === false) {
            return undefined;
        }
    }
   }
   */
  //28. own attempt. not working
    /*
    findKey(object, fPerIteration) {
        for (let key in object) {
            fPerIteration(object)
            if (fPerIteration(object) === true) {
                return object[key];
            } else if (fPerIteration(object) === false) {
                return undefined;
            }
        }
    }
    */
   //own attmept corrected. error was that the computer was instructed to call the function with a parameter of the object instead of the object key. seen as how the method is
   //called find key. it makes sense that the function that method calls should have the objects key as a parameter and not just the object. Also the method was coded earlier
   //to check if calling the function with a parameter with the object returned true instead of checking if calling the function with a parameter of the objects key would 
   //return true. The same was an error witht he else if statement. also another error was that ones own attempt first had an error of returning the objects key value, 
   //instead of returning just the key. One last thing worth mentioning is that in codecademys version of code. They made the if statement after the loop. Not sure
   //if this is necessary. since own attempt seems to pass code tests now. Though not sure. I prefer this solution since i think its easier to see what every if statement checks
   //instead of having to remember what each variable is. it instead shows more clearly what each if statement checks.

    findKey(object, fPerIteration) {
        for (let key in object) {
            fPerIteration(object[key])
            if (fPerIteration(object[key]) === true) {
                return key;
            } else if (fPerIteration(object[key]) === false) {
                return undefined;
            }
        }
    },
  
    //29. codecademy version. working. 
    /*
    findKey(object, predicate) {
        for (let key in object) {
            let value = object[key];
            let predicateReturnValue = predicate(value);
            if (predicateReturnValue === true) {
                return key;
            }
        }
        return undefined
    }
    */
   //31. own attempt. think it works.
   /*
    drop(array, number) {
        if (number === undefined) {
            number = 1;
        }
        for (let i = 0; i < number; i++) {
            array.shift();
        }
        return array;
    }
    */
    //32. i prefer this solution. since another programmer would be able to see that the second parameter for the method is a number and not just n. n isnt that specific in my
    //opinion. I prefer the readability of 31. however this code is more flexible so i think this is the better solution.
    
    drop(array, number) {
        if (number === undefined) {
            number = 1;
        }
        const newArray = array.slice(number);
        return newArray;
    },
   //33.
   //codecademy version.
   /*
   drop(array, n) {
    if (n === undefined) {
        n = 1;
    }
        const droppedArray = array.slice(n);
        return droppedArray;
   }
   */
   //35.
   //should make the method. then insert the parameters array and the function per iteration. The function then in the method code block takes 3 parameters. current element.
   //element index and the whole array. maybe a little after that use the shift method in a for loop though not sure.
   //not sure if this will work. there might be an error with the assignment of the modified array in the loop though im not sure. also doesnt use the findIndex method.
   //not sure where it should be used.
   //doesnt work.
   /*
   dropWhile(array, fPerIteration) {
    let modifiedArray = array;
    for (let i = 0; i < array.length; i++) {
        if (array[i] === true) {
            modifiedArray = this.drop(array, 1);
        } else if (array[i] === false) {
            break;
        }
    }
    return modifiedArray;
   }
   */
   //codecademy guideline version.
   dropWhile(array, predicate) {
    let dropNumber = array.findIndex(function(element, index) {
        return !predicate(element, index, array)
    });
    let droppedArray = this.drop(array, dropNumber);
    return droppedArray;
   },
   //39.
   //CONFUSED
   //the method should first be defined in the _ object. the method takes two parameters. an array and a number to indicate the size of each chunk that the array should
   // be divided into. maybe this could be done by making a new array. that array should have x (size) amount of array spaces in the array. Maybe this could be done with a loop.
   //maybe an if statement could then check if the length of the remaining spaces in the old array are less than the required amound. then they should all be put together in the
   //last space of the new array. then an if statement might be able to assign size to 1 if the size parameter hasnt been assigned a value in the method call.
   //40.
   //dont think this work though im not sure how to assign nested spaces in an array also im unsure how to do the last pop in with the remainding arrays.
   //missing an if else to pop the last entries into the array. and i think some other things as well.
   //after checking codecademy version:
    /*
    //først defineres metoder. derefter angives metodne med array og size parametre.
   chunk(array, size) {
    //derefter tjekkes det om size har en værdi. hvis size ikke har en værdi så vil size blive angivet til 1. altså at hver chunk skulle have en størrelse på 1.
    if (size === undefined) {
        size = 1;
    }
    //dernæst skabes en array med tomme pladser der skulle kunne modtage den originale array delt op i chunks.
    let newArrayWithChunks = [];
    //her defineres en variable kaldet count. tanken var denne skulle hjælpe med at holde styr på hver plads i newArrayWithChunks. så i måske kunne referere til hvert element
    //hvor count måske kunne referere til hver chunk. men ikke sikker.
    let count = 0;
    //her defineres et loop. her i loopet vil en variabel skabes kaldet i. derefter vil loopet køre så længe i er mindre end array'ets længde. hver gang loopet har kørt så
    //ville i være = i + 1.
    for (let i = 0; i < array.length; i++) {
        //hver gang loopet kører vil pladsen på count med et index af i blive sat = arrayens index. problemet med dette er at hvis i f.eks. 4. og size er 1
        //så vil den forsætte med at indsætte pladser. dette loop tager ikke højde for size. det vil sige ligegyldig hvad så vil der være et element på en plads altså
        //hver kategori i newArrayWithChunks har kun en størrelse på en og vil følge det originale array. altså er fejlen ved ikke at bruge size tror jeg og i brugen af count.
        //da den dermed ville kun placere en ved hver kategori.
        newArrayWithChunks[count][i] = array[i]
        count++;
    }
    console.log(arrayChunks);
    return newArrayWithChunks;
   }
   */

  //41. codecademy version working.
  //CONFUSED
  /*
  //first a method gets defined. that takes a parameter of an array and then a parameter of size.
  chunk(array, size) {
    //then an if else statement gets defined that checks if size is undefined. if it is size gets put to 1.
    if (size === undefined) {
        size = 1;
    }
    //then we define an empty array that will receive the splittet up array.
    let arrayChunks = [];
    //then we make a for loop. it defines a variable i and sets it to 0. then as long as i is smaller than the array's length. i will be sat = to i + size.
    for (let i = 0; i < array.length; i = i + size) {
        //everytime the loop runs we define a variable called arrayChunk and set it equal to the slice method called on the passed in array. then we copy from i to i+size
        //from the passed in array. since we want to make sure we grab the index in the passed array from where the loop is currently at. Then we want to plus i with size as
        //the end parameter since we dont want each chunk to be bigger than the specified size for each chunk.
        let arrayChunk = array.slice(i, i+size);
        //then with the .push method called on the new receiving array. We add the previously defined arrayChunk variable. at the end of the arrayChunks array that we defined
        //close to the beginning of the method.
        arrayChunks.push(arrayChunk);
    }
    //then we return the arrayChunks so we can save these values for later so we can use them in the tests to check if our code was correct.
    return arrayChunks;
  }
  */
 //codecademy version skrevet ind efter det blev husket. uden at kigge på deres kode for at se om man havde forstået det lidt. 
    chunk(array, size) {
        if (size === undefined) {
            size = 1;
        }
        let receiverArray = [];
        for (let i = 0; i < array.length; i = i+size) {
            let arrayChunk = array.slice(i, i+size);
            receiverArray.push(arrayChunk);
        }
        return receiverArray;
    }
   
};

//test for 23.
const testTestoObjecto = { a: 1, b: 2, c: 3 };

console.log(_.invert(testTestoObjecto));

//2. done

//3. own test attempt 
//console.log(_.clamp(-10, -5, 5));

console.log(_.inRange(3, 2, 4));
// => true
 
console.log(_.inRange(4, 8));
// => true
 
console.log(_.inRange(4, 2));
// => false
 
console.log(_.inRange(2, 2));
// => false

//conclusion. i feel like i could use more practice with objects in javascript. specifically how to assign or acces keys and or values of an object so far.

// Do not write or modify code below this line.
module.exports = _;