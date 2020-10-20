console.log('Hello World'); //Prints Hello World
console.log(2019); //Prints 2019

console.log('Hello' + 2019); //Prints Hello 2019
console.log('Hello' + 'World'); //Prints HelloWorld
console.log('Hello' + ' ' + 'World'); //Prints Hello World
console.log('Hello ' + 'World'); //Prints Hello World
console.log('Hello' + ' World'); //Prints Hello World

console.log('Hello World'.length); //.length counts number of charcaters and displays as a number. In this case 11.
console.log('HelloWorld'.length); //.length counts number of charcaters and displays as a number. In this case 10.

console.log(50 + 5); //Prints 55
console.log(50 - 5); //Prints 45
console.log(50 * 5); //Prints 250
console.log(50 / 5); //Prints 10

console.log('hello'.toUpperCase()); //Prints HELLO
console.log('Hey'.startsWith('H')); //Prints true
console.log('	Remove Whitespace	'.trim()); //Prints Remove Whitespace

console.log(Math.random()); //Prints a random number between 0 and 1
console.log(Math.random() * 50); //Prints a random number between 0 and 50, usually resulting in decimals
console.log(Math.floor(Math.random() * 50)); //Prints a random number between 0 and 50, the decimals being rounded by Math.floor()

var myName = 'Kridtity Ikhlaas Lawang'; //The variable 'myName' has the value 'Kridtity Ikhlaas Lawang'
console.log(myName); //Prints the value of the variable

let pizza = 'bad';
console.log('Pizza is ' + pizza);
pizza = 'good';
console.log('Pizza is ' + pizza);

const author = 'Kridtity I. Lawang';
console.log(`The author is ${author}.`); //Example of a template literal

const one = 'code';
console.log(typeof one); //Prints string
const two = 2019;
console.log(typeof two); //Prints number
const three = true; 
console.log(typeof three); //Prints boolean

const uStinks = 'Yes.';
console.log(`Does Ubaydah stink? ${uStinks}`);