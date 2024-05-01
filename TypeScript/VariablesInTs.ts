/*
Number
string
boolean
any
void
null
undefined
array
tuple
enum
*/

let num1:number;
num1=45;
console.log(num1);

let str1:string='niranjan';
let boolTest:boolean;
boolTest=true;

let sum:number;
//sum=num1+parseInt(str1);
console.log(sum);

let arr=['e','er',43,true];
console.log(arr);

let arr1:number[]=[32,3,43];

console.log(arr1);
for(let a of arr1){
    console.log(typeof a);
    console.log(a);
}
 //let color:enum=[red,green,blud];

 console.log('end');

enum colors{red=5,green,blue};
let _color:colors=colors.blue;
console.log(_color);

// type alise;
type stringOrint=string|number;

let num3:stringOrint;
num3=32;
console.log(num3);
num3='newValue';
console.log(num3);
num3=null;
console.log(num3);
let str:string=null;

let numArr:number[]=[ 43,43,55,5];

var anyVar:any='string value';
console.log(anyVar);
anyVar=488;
console.log(anyVar);
anyVar=true;
console.log(anyVar);




