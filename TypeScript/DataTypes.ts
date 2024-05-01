/*
Number 
Boolean
String
Array
Tuple
Enum
Any
Void
Union types
Type alias

*/

let numTest:number;
let strTest:string;
let boolTest:boolean=true;

//let variablename:datatype=value;

// let arr:number[];
// arr=[78,89,90];
// console.log(arr);

let arr :Array<number> =[23,23,44];
console.log(arr);

// 
enum Colors{red=10, green,blue};
let _color:Colors=Colors.red;
console.log(_color);
//Tuple:
let _tpl:[number,string,string];
//_tpl=[23,56,'hello'];
console.log(_tpl);

let anyTest:any;
anyTest="niranjan";
console.log(typeof anyTest);
anyTest=90;
console.log(typeof anyTest);
anyTest=true;
console.log(typeof anyTest);


let unTest:string|number; //union type;
unTest=89;
unTest='dgdgd';
console.log(unTest);

type stringOrInt =string|number;

let unTest2:stringOrInt;
unTest2=89;
unTest2='dgdgd';
unTest2=true;
console.log(unTest2);












