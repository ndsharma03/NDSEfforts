// variables in type script

//********number****** */

let varNumber:number;
console.log(varNumber=333);
//console.log(varNumber="333");  // it will not compile as "333" is a string.

//********string****** */
let varString :string ="Niranjan";
varString="333";
console.log(varString);

//********Boolean****** */
let varBoolean:boolean;
varBoolean=true;
console.log(varBoolean);

//********Array****** */
let varIntArray:number[];
varIntArray=[23,73,53,43];
console.log(varIntArray);

// another way to declare array..
let varNumArray:Array<Number>;
varNumArray=[34.44,4,22,56];
console.log(varNumArray);
//below line will generate error as varNumArray will take only numbers.

// varNumArray=[7483,"894",true];
// console.log(varNumArray);

let intTuple :[string, number];
intTuple=["hello",2];
console.log(intTuple);

let strTuple:[number,string]=[32,"djid"];
console.log(strTuple);
// strTuple=["fist","secind"]
// console.log(strTuple);

let intTuple2:[number,number]=[32,34]; 