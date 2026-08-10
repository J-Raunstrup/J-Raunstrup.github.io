/*make an object with different methods. The methods need to be able to do 5 different things.
x? might need some extra stuff regaridng adding in the corresponding element in the list? 1: add things to the end of the list
x2: remove an index from the list
x3: remove all elements from a list
x?4: insert a element at a given index
x5: gets the element at a given index.
*/
/*
const objectWithListMethods = {
    addAtEndOfList: "test1",
    removeIndexFromList: "test2",
    removeAllElementsFromList: "test3",
    insertElementAtIndex: "test4",
    getElementAtIndex: "test5"
}

console.log(objectWithListMethods)
*/
const objectWithListMethods = {
    addAtEndOfList(list, element) {
       
        const aNewList = [list+element]
        return aNewList

    },
    removeIndexFromList(list, indexToRemove) {
        
        let aNewList = [];

        for (let loopIndex = 0; loopIndex < list.length; loopIndex++) {
            if (list[loopIndex] !== list[indexToRemove]) {
                aNewList = [aNewList+list[loopIndex]]

            }
        }

        console.log(aNewList)
        return aNewList
    },
    removeAllElementsFromList(list) {
        list = [];
        console.log(list)
        return list
    },
    insertElementAtIndex(list, indexToAddAt, element) {
        let aNewList = [];
        let endIndexOfFirstLoop = 0.
        for (let loopIndex = 0; loopIndex < indexToAddAt; loopIndex++) {
   
                aNewList = [aNewList+list[loopIndex]]
                endIndexOfFirstLoop++;
           }

           aNewList = [aNewList+element]
        for (let loopIndexNumber2 = endIndexOfFirstLoop; endIndexOfFirstLoop < list.length; endIndexOfFirstLoop++) {
            aNewList = [aNewList+list[loopIndexNumber2]]
        }
   
        //endten et loop indtil index nås. tilføj punkt. derefter kør nyt loop. eller måske noget andet.

        console.log(aNewList)
        return aNewList
    },
    getElementAtIndex(list, index) {
        for (let loopIndex = 0; loopIndex < list.length; loopIndex++) {
            if (loopIndex === index) {
                console.log(list[loopIndex])
                return list[loopIndex];
            }
        }
    }
}



console.log(objectWithListMethods)

let aTestList = ["benny", "and", "brian", "yelled"]

let theNewTestList = []

console.log(aTestList)

theNewTestList = objectWithListMethods.addAtEndOfList(aTestList, " YEET")


theNewTestList = objectWithListMethods.removeIndexFromList(aTestList, 2)

objectWithListMethods.removeAllElementsFromList()

objectWithListMethods.insertElementAtIndex(aTestList, 3, "YEET")

objectWithListMethods.getElementAtIndex(aTestList, 1)

console.log(aTestList)