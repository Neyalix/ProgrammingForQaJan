// let text = 'I love JS';
// let j = 'JS';

// console.log(text + ' ' + j);
// console.log(text.concat(j));
// console.log(text.indexOf('love'));

// // =====================Split toArray===============
// let strArr = text.split(" ");
// console.log(strArr);
// // =====================includes===============
// console.log(text.includes('JS'));
// console.log(text.includes('C#'));

// // =====================repeat===============
// let str = "**";
// console.log(str.repeat(str.length))


// // // =====================startsWith===============
// // console.log(text.startsWith('I love')); // Returns true
// // console.log(text.startsWith('I am')); // Returns false

// // //=====================endsWith=================

// // console.log(text.endsWith('JS'));
// // console.log(text.endsWith('C#'));

// // // =====================padStart===============
// // let padText = 'We are the Champions';

// // console.log(padText.padStart(24, 'Yes '));


// // // =====================padEnd===============

// // console.log(padText.padEnd(21, '!'));

// // =====================objects===============

// let person = {
//     name: 'Philip Mihaylov',
//     city: 'Sofia',
//     age: 25,
//     sayHello: function() {
//         console.log('Hello from Philip');
        
//     },
//     eat(){
//         console.log('I am eating');
        
//     }

// }

// person.address = 'zhk Gotse Delchev';


// console.log(`Name: ${person.name} City: ${person.city} Age: ${person.age} Addres: ${person.address}`);
// delete person.age;
// console.log(person);

// // person['last name'] = 'Mihaylov';
// // console.log(person);

// person.sayHello();
// person.eat();

// person.driveACar = () => console.log('Philip is driing a Ford Mondeo');

// person.driveACar();

// console.log(Object.keys(person));
// console.log(Object.values(person));

// for (let i = 0; i < Object.entries(person).length; i++) {

//     console.log(Object.entries(person)[i]); 

// }

// // =====================associate arrays===============

// let assocArr = {
//     'one': 1,
//     'two': 2,
//     'three': 3
// }

// assocArr['four'] = 4

// assocArr.five = 5

// console.log(Object.values(assocArr));


// for (const key in assocArr) {
//     console.log(`${key} => ${assocArr[key]}`);
    
// }

// // =====================has own property===============
// // returns boolean
// console.log(assocArr.hasOwnProperty('one'));
// console.log(assocArr.hasOwnProperty('six'));

// // =====================arrays sorting===============

// let numbers = [1, 200, 13, 40, 5];

// console.log(numbers);

// numbers.sort((a, b) => a - b) //sort in ascending order

// console.log(numbers);

// numbers.sort((a, b) => b -a) //sort in descending order

// console.log(numbers);

// // // =====================arrays destructing ===============

// let nums = [20, 30 ,40, 50, 60];
// let[num1, num2] = nums;

// let num3 = nums[2];

// console.log(num1);
// console.log(num2);
// console.log(num3);

// // =====================functions ===============

function sum1(x, y) {
    
    return x + y;


}
console.log(sum1(5, 9)); // call function

let sum = sum1(2, 8); //assign

console.log(sum); 

// // =====================Arrow functions ===============

let multiply = (x, y) => x * y;
console.log(multiply(4, 4));


