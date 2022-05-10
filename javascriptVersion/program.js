let welcome = (name) => console.log(`Welcome friend ${name}!`)

let addTwoNums = (num1, num2) => num1 + num2;

console.log(addTwoNums(60, 9))

let sum = 0;
let numbers = []
for (let i=0; i<5;i++) 
{
    numbers[i] = prompt();
}
let sumArray = arr => arr.reduce((prev, curr) => prev + curr);
sum = sumArray(numbers)


let raiseToN = (base, expo) => Math.pow(base, expo);

let basenum = prompt();
let expon = prompt();
console.log(raiseToN(basenum, expon))

let fibSeq = index => {
    a = 0
    b = 1
    for (let j = 0; j< index; j++) {
        a=b
        b=a+b
    }
    console.log(b)

}
fibSeq(2)