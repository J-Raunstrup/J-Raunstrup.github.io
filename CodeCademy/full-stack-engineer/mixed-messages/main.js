
//1.
//deadline. 1 week.
//what is it built with? vs studio code. probably with a let ranNum = math.random()* maxNum. then maybe an array with nested arrays. and then it uses a for 
//loop to log everything untill i is = array[ranNum][i].length.

//what can it do? (before hint.) return a random fact. the fact is an array. it has 2 spaces. first space is a number. second space is the fact. The fact starts with a 
//: then after that it has a space followed by the fact. since the program requires 3 different pieces of data. object (array) is one. 
//the second is a number at the beginning of the fact. the third is the string.

//2.
//what can it do? (checked hint.) it said just 3 different pieces of data. not 3 different data types. this makes it more fun.
//what can it do? return a random videogame. first the name. then the genre and console, then the metacritic score. it can recommend videogames for people. so it just outputs random good 
//games that has a rating of at least 8.5. so its a quality rnadom game generator.

//3.
let arrayWithGames = [
    ["Name: Elden Ring", "Genre: Action/RPG", "Platform: PS5/Xbox X/PS4/Xbox one/PC", "Metacritic score: 96"],
    ["Name: The Witcher 3", "Genre: Action/RPG", "Platform: All platforms", "Metacritic score: 94"],
    ["Name: Persona 5 Royal", "Genre: JRPG", "Platform: All platforms", "Metacritic score: 91"],
    ["Name: GTA V", "Genre: Open-World-Action", "Platform: PC/Playstation/Xbox", "Metacritic score: 97"],
    ["Name: Super Mario Odyssey", "Genre: 3D Platformer", "Platform: Nintendo switch", "Metacritic score: 97"],
    ["Name: The Legend Of Zelda Breath Of The Wild", "Genre: Open-World-Action", "Platform: Nintendo Switch", "Metacritic score: 97"],
    ["Name: Metal Gear Solid V: The Phantom Pain", "Genre: Stealh/Open-World", "Platform: Playstation/Xbox/PC", "Metacritic score: 93"],
    ["Name: Hollow Knight", "Genre: Metroidvania", "Platform: All platforms", "Metacritic score: 90"],
    ["Name: Resident Evil 4 remake", "Genre: Survivalhorror", "Platform: Playstation/Xbox/PC", "Metacritic score: 93"],
    ["Name: God of War", "Genre: Action-adventure", "Platform: PS4", "Metacritic score: 94"]
];

const videoGameRecommender = (array) => {
    console.log("");
    console.log("Random Videogame Recommendation:");

    let randomNumber = Math.floor(Math.random() * array.length);
    let randomGame = array[randomNumber];

    console.log("");
    for (let i = 0; i < array[randomNumber].length; i++) {
        console.log(randomGame[i]);
    }
    console.log("");
}

videoGameRecommender(arrayWithGames);