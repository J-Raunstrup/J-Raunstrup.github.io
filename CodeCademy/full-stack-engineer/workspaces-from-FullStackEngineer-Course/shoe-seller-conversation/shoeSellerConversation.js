
/*write a pair of shoes in here. Use one of the following presets:
(yeezy, converse, nike af1.) (make sure to delete the ',', ' ' or the '.' signs.)
*/

let pairOfShoes = 'converse'



let startSentenceBuyer = 'Buyer: '

let startSentenceSeller = 'Seller: '



switch (pairOfShoes) {
  case 'yeezy':
  console.log((startSentenceBuyer) + 'Damn bro. Thats a pair of yeezys right there!');
  break;
  case 'converse':
  console.log((startSentenceBuyer) + 'Why use those old shoes bro. They look really worn down bro.')
  break;
  case 'nike af1':
  console.log((startSentenceBuyer) + 'Alright alriht bro i see you. Might not be orignal but those air force 1\'s look hella clean');
  break;
  default:
  console.log((startSentenceBuyer) + 'Ayy bro. Hit me with some sneakers. I am interesed in the following: yeezy, converse and nike af1');
  break;
} 

//Here is an extra line that asks for the price
console.log(startSentenceBuyer + 'If i was gonna buy them. How much do they cost?');



let ShoesPrice = 200



//type a price in on the line below where it says ('give me a price')
if (ShoesPrice = 20){
console.log(startSentenceSeller + ShoesPrice + ' dollars');
} 

if (ShoesPrice === 200) {
  console.log(startSentenceBuyer + 'Thats a good price');
} else if (ShoesPrice >= 201) {
  console.log(startSentenceBuyer + 'Bro thats way too expensive. No one can afford that.');
} else if (ShoesPrice <= 199) {
console.log(startSentenceBuyer + 'Damn imma buy that right away')
} else if (startSentenceBuyer + ShoesPrice === 'give me a price') {
  console.log(' ')
} else {
  console.log(startSentenceBuyer + 'Bro thats not a price. Give me a price');
}


console.log(startSentenceSeller + 'Can i get you to buy them?')

console.log(startSentenceBuyer + '(I need to make sure they arent fake before i buy them)') 

console.log(startSentenceBuyer + 'Maybe. Let me check if they are real or fake first. (I inspected them for a bit.)') 
console.log(startSentenceSeller + 'So are the shoes real?');



//change if the shoes are legit or not by writing one of the following: ('true' or 'false')

let areTheShoesReal = true



if (areTheShoesReal === true) {
  console.log(startSentenceBuyer + 'Yeah. Since they\'re real im buying them for that price');
} 
else if (areTheShoesReal === false)
{
  console.log(startSentenceBuyer + 'Nope. They\'re fake bro');
}